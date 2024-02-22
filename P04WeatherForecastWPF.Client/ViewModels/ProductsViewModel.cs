using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P04WeatherForecastWPF.Client.Models;
using P04WeatherForecastWPF.Client.Services;
using P06Shop.Shared;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastWPF.Client.ViewModels
{
    public partial class ProductsViewModel : ObservableObject
    {
        private readonly IProductService _productService;
        private readonly IMessageDialogService _messageDialogService;
        private readonly ProductDetailsView _productDetailsView;
        private readonly ISpeechService _speechService;

        [ObservableProperty]
        private ObservableCollection<Product> _products;


        [ObservableProperty]
        private Product _selectedProduct;

        partial void OnSelectedProductChanged(Product value)   
        {
            DeleteCommand.NotifyCanExecuteChanged();
        }

        public ProductsViewModel(IProductService productService, IMessageDialogService messageDialogService, 
            ProductDetailsView productDetailsView, ISpeechService speechService)
        {
            _productService = productService;
            _messageDialogService = messageDialogService;
            _productDetailsView = productDetailsView;
            _speechService = speechService;
        }

        public async Task GetProductsAsync()
        {
            var result = await _productService.GetProductsAsync();
            if (result.Success)
            {
                Products = new ObservableCollection<Product>(result.Data);
            }
        }

        public async Task CreateProductAsync()
        {
            var result = await _productService.CreateProductAsync(_selectedProduct);
            if (result.Success)
            {
               await GetProductsAsync();
            }
            else
            {
                _messageDialogService.ShowMessage(result.Message);
            }
           
        }

         

        public async Task UpdateProductAsync()
        {
            var result = await _productService.UpdateProductAsync(_selectedProduct);
            if (result.Success)
            {
                await GetProductsAsync();
            }
            else
            {
                _messageDialogService.ShowMessage(result.Message);
            }
        }

        [RelayCommand]
        public async Task ShowDetails(Product product)
        {
            _productDetailsView.Show();
            SelectedProduct = product;
            _productDetailsView.DataContext = this;
        }


        [RelayCommand(CanExecute = nameof(CanDelete))]
        public async Task Delete()
        {
            var result = await _productService.DeleteProductAsync(_selectedProduct.Id);
            if (result.Success)
            {
                _productDetailsView.Hide();
                await GetProductsAsync();
            }
            else
            {
                _messageDialogService.ShowMessage(result.Message);
            }
        }

        public bool CanDelete()
        {
            return _selectedProduct != null && _selectedProduct.Id != 0;
        }

        [RelayCommand]
        public async Task Save()
        {
            if (_selectedProduct.Id==0)
            {
                // tworzymy nowy produkt 
                await CreateProductAsync();
            }
            else
            {
                // aktualizujemy produkt
                await UpdateProductAsync();
            }
        }

        [RelayCommand]
        public async Task New()
        {
            _productDetailsView.Show();
            _productDetailsView.DataContext = this;
            SelectedProduct = new Product();
        }

        [RelayCommand]
        public async Task RecognizeVoice()
        {
            var text = await _speechService.RecognizeAsync();
            //  SelectedProduct.Description = text;


            SelectedProduct = new Product()
            {
                Id = _selectedProduct.Id,
                Description = text,
                Barcode = _selectedProduct.Barcode,
                Title = _selectedProduct.Title,
                Price = _selectedProduct.Price,
                ReleaseDate = _selectedProduct.ReleaseDate
            };

        }
    }
}


 