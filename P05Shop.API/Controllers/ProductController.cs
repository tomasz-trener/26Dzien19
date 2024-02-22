using Microsoft.AspNetCore.Mvc;
using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService; // wstrzyknięcie zależności
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceReponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, $"Internal server error {result.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<ServiceReponse<Product>>> CreateProduct([FromBody] Product newProduct)
        {
            var result = await _productService.CreateProductAsync(newProduct);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        // https://localhost:5001/api/product/1 (DELETE)
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceReponse<bool>>> DeleteProduct([FromRoute] int id)
        {
            var result = await _productService.DeleteProductAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        // przykład polecenia niezgodnego z REST
        // https://localhost:5001/api/product/delete?id=1 (DELETE)
        [HttpGet("delete")]
        public async Task<ActionResult<ServiceReponse<Product>>> DeleteProductNotInRESTSpecyfication([FromQuery] int id)
        {
            var result = await _productService.DeleteProductAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpPut]
        public async Task<ActionResult<ServiceReponse<Product>>> UpdateProduct([FromBody] Product updatedProduct)
        {
            var result = await _productService.UpdateProductAsync(updatedProduct);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceReponse<Product>>> GetProduct([FromRoute] int id)
        {
            var result = await _productService.GetProductAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpGet("search/{text}/{page}/{pageSize}")]
        [HttpGet("search/{page}/{pageSize}")]
        public async Task<ActionResult<ServiceReponse<List<Product>>>> SearchProducts([FromRoute] string? text =null, [FromRoute] int page=1, [FromRoute] int pageSize=10)
        {
            var result = await _productService.SearchProductsAsync(text, page, pageSize);

            if (result.Success)
                return Ok(result);
            else
                return StatusCode(500, $"Internal server error {result.Message}");
        }
    }


}
