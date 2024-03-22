using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        List<Category> _categories;        

        public CategoryManager()
        {
            _categories = new List<Category>();
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int CategoryId)
        {
            var existingProduct = _categories.FirstOrDefault(p => p.CategoryId == CategoryId);
            if (existingProduct != null)
            {
                _categories.Remove(existingProduct);
            }
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int CategoryId)
        {
            return _categories.FirstOrDefault(p => p.CategoryId == CategoryId);
        }

        public void Update(Category category)
        {
            var existingProduct = _categories.FirstOrDefault(p => p.CategoryId == category.CategoryId);
            if (existingProduct != null)
            {
                // Ürün özelliklerini güncelle
                //existingProduct.Id = product.Id;
                existingProduct.CategoryName = category.CategoryName;
                existingProduct.CategoryDescription = category.CategoryDescription;
                // Diğer özellikler gerektiği gibi güncellenir
            }
            else
            {
                throw new Exception("Category bulunamadı.");
            }
        }
    }
}
