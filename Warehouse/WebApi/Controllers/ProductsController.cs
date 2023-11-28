using Bogus;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation($"{nameof(ProductsController)} - {GetType().Name}:");

            var faker = new Faker<Products>("pt_BR");

            var products = faker.Generate(10);

            return Ok(products);
        }
    }
}