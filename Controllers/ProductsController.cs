using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restSQL.Models;
using restSQL.Respository;

namespace restSQL.Controllers
{
    [Route("/[products]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly ProductsInMemory repository;

        public ProductsController()
        {
            repository = new ProductsInMemory();
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var products = repository.GetProducts();
            return products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = repository.GetProductById(id);

            if (product is null)
            {
                return NotFound();
            }

            return product;
        }
    }
}
