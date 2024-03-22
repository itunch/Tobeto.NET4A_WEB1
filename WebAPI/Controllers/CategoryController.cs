using Business.Abstracts;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService) 
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> GetAll()
        {
            return categoryService.GetAll();
        }

        [HttpPost]
        public void Added([FromBody] Category category) 
        {
            categoryService.Add(category);
        }

        [HttpPut("{id}")]
        public void Update([FromBody] Category category) 
        {
            categoryService.Update(category);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            categoryService.Delete(id);
        }

        [HttpGet("{id}")]
        public Category GetById(int id)
        {
            return categoryService.GetById(id);
        }
    }
}
