using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;
using P07Shop.DataSeeder;

namespace P05Shop.API.Services
{
    public class ProductFakeService : IProductService
    {
        public Task<ServiceReponse<Product>> CreateProductAsync(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<bool>> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<Product>> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceReponse<List<Product>>> GetProductsAsync()
        {
            var result = new ServiceReponse<List<Product>>();

            try
            {
                result.Data = ProductDataSeeder.GenerateProductData();
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

        public Task<ServiceReponse<List<Product>>> SearchProductsAsync(string text, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<Product>> UpdateProductAsync(Product updatedProduct)
        {
            throw new NotImplementedException();
        }
    }
}
