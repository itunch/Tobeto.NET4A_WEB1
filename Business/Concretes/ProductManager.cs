using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        List<Product> products;

        public ProductManager()
        {
            this.products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Delete(int id)
        {

            var existingProduct = products.FirstOrDefault(p => p.Id == id);

            if (existingProduct != null)
            {
                products.Remove(existingProduct);
            }

            //var existingProduct = products.RemoveAll(p => p.Id == id);

        }

        public List<Product> GetAll()
        {
            return this.products;
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }        
                

        public void Update(Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                // Ürün özelliklerini güncelle
                //existingProduct.Id = product.Id;
                existingProduct.Name = product.Name;
                existingProduct.UnitPrice = product.UnitPrice;
                // Diğer özellikler gerektiği gibi güncellenir
            }
            else
            {
                throw new Exception("Ürün bulunamadı.");
            }
        }
    }
}
