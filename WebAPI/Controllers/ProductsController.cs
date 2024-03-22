using Business.Abstracts;
using Business.Concretes;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService productService; // ❌❌❌

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return productService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Product product)
        {
            productService.Add(product);
        }

        [HttpPut("{id}")]
        public void Update([FromBody] Product product)
        {
            productService.Update(product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            productService.Delete(id);
        }

        [HttpGet("{id}")]
        public Product GetById(int id) 
        {
            return productService.GetById(id);
        }

    }
}
