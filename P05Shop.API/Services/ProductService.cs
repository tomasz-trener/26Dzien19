using Microsoft.EntityFrameworkCore;
using P05Shop.API.Models;
using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;
using P07Shop.DataSeeder;

namespace P05Shop.API.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;

        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ServiceReponse<List<Product>>> GetProductsAsync()
        {
            var result = new ServiceReponse<List<Product>>();

            try
            {
                result.Data = await _dataContext.Products.ToListAsync();
                result.Success = true;
                result.Message = "Data retrieved successfully";
            }
            catch (Exception ex)
            {
                result.Message = $"Error retrieving data from the database {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        public async Task<ServiceReponse<Product>> CreateProductAsync(Product newProduct)
        {
            var result = new ServiceReponse<Product>();

            try
            {
                await _dataContext.Products.AddAsync(newProduct);
                await _dataContext.SaveChangesAsync();

                result.Data = newProduct;
                result.Success = true;
                result.Message = "Data created successfully";
            }
            catch (Exception ex)
            {
                result.Message = $"Error while creating new product {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        // Tutaj mamy 2 zapytania do bazy danych, jedno pobiera produkt, drugie usuwa produkt
        public async Task<ServiceReponse<bool>> DeleteProductAsync(int id)
        {
            var result = new ServiceReponse<bool>();

            try
            {
                var product = await _dataContext.Products.FirstOrDefaultAsync(p => p.Id == id);

                if (product != null)
                {
                    _dataContext.Products.Remove(product);
                    await _dataContext.SaveChangesAsync();

                    result.Data = true;
                    result.Success = true;
                    result.Message = "Data deleted successfully";
                }
                else
                {
                    result.Message = $"Product with id {id} not found";
                    result.Success = false;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"Error while deleting product {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        // Można to zrobić w jednym zapytaniu do bazy danych
        public async Task<ServiceReponse<Product>> DeleteProductOneQueryAsync(int id)
        {
            var result = new ServiceReponse<Product>();

            try
            {
                var product = new Product() { Id = id };
                _dataContext.Products.Attach(product); // załączenie produktu do kontekstu

                _dataContext.Products.Remove(product); // wyśle tylko jedno zapytanie do bazy danych
                await _dataContext.SaveChangesAsync();
                result.Data = product;
                result.Success = true;
                result.Message = "Data deleted successfully";

            }
            catch (Exception ex)
            {
                result.Message = $"Error while deleting product {ex.Message}";
                result.Success = false;
            }

            return result;

        }

        public async Task<ServiceReponse<Product>> UpdateProductAsync(Product updatedProduct)
        {
            var result = new ServiceReponse<Product>();

            try
            {
                var product = await _dataContext.Products.FirstOrDefaultAsync(p => p.Id == updatedProduct.Id);

                if (product != null)
                {
                    product.Title = updatedProduct.Title;
                    product.Description = updatedProduct.Description;
                    product.Barcode = updatedProduct.Barcode;
                    product.Price = updatedProduct.Price;
                    product.ReleaseDate = updatedProduct.ReleaseDate;

                    await _dataContext.SaveChangesAsync();

                    result.Data = product;
                    result.Success = true;
                    result.Message = "Data updated successfully";
                }
                else
                {
                    result.Message = $"Product with id {updatedProduct.Id} not found";
                    result.Success = false;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"Error while updating product {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        public async Task<ServiceReponse<Product>> UpdateProductOneQueryAsync(Product updatedProduct)
        {
            var result = new ServiceReponse<Product>();

            try
            {
                var product = new Product() { Id = updatedProduct.Id };
                _dataContext.Products.Attach(product); // załączenie produktu do kontekstu

                product.Title = updatedProduct.Title;
                product.Description = updatedProduct.Description;
                product.Barcode = updatedProduct.Barcode;
                product.Price = updatedProduct.Price;
                product.ReleaseDate = updatedProduct.ReleaseDate;

                await _dataContext.SaveChangesAsync();

                result.Data = product;
                result.Success = true;
                result.Message = "Data updated successfully";

            }
            catch (Exception ex)
            {
                result.Message = $"Error while updating product {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        public async Task<ServiceReponse<Product>> GetProductAsync(int id)
        {
            var result = new ServiceReponse<Product>();

            try
            {
                result.Data = await _dataContext.Products.FirstAsync(p => p.Id == id);
                // first rzuca wyjątek jeśli nie znajdzie produktu
                // firstordefault zwraca null jeśli nie znajdzie produktu

                result.Success = true;
                result.Message = "Data retrieved successfully";
            }
            catch (Exception ex)
            {
                result.Message = $"Error retrieving data from the database {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        public async Task<ServiceReponse<List<Product>>> SearchProductsAsync(string text, int page, int pageSize)
        {
            IQueryable<Product> query= _dataContext.Products;

            if (!string.IsNullOrEmpty(text))
            {
                query = query.Where(p => p.Title.Contains(text) || p.Description.Contains(text));
            }

            try
            {
                var products = await query
                .Skip(pageSize * (page - 1))
                .Take(pageSize)
                .ToListAsync();

                var response = new ServiceReponse<List<Product>>()
                {
                    Data = products,
                    Success = true,
                    Message = "Data retrieved successfully"
                };
                return response;
            }
            catch (Exception)
            {
                 var response = new ServiceReponse<List<Product>>()
                 {
                      Data = null,
                      Success = false,
                      Message = "Error retrieving data from the database"
                 };
                 return response;   
            }

            


        }
    }
}
