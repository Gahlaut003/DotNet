/*using Microsoft.AspNetCore.Mvc;
using Utility_001.Data;
using Utility_001.Repository;
using Utility_001.Services;

namespace Utility_001.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase  // Corrected: ControllerBase is better for API
    {
        private readonly IProductRepository _repository;
        private readonly IProductService _productService;

        // ✅ Constructor Injection
        public ProductsController(IProductRepository repository, IProductService productService)
        {
            _repository = repository;
            _productService = productService;
        }

        // ✅ 1. Get all products
        [HttpGet("GetAllProds")]
        public IActionResult GetProducts()
        {
            var products = _repository.GetAllProducts();
            return Ok(products);
        }
*//*
        // ✅ 2. Get a single product by ID (New Method)
        [HttpGet("GetProduct/{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _repository.GetProductById(id);
            if (product == null)
                return NotFound($"Product with ID {id} not found");

            return Ok(product);
        }

        // ✅ 3. Add a new product (New Method)
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _repository.AddProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }*//*
    }
}
*/