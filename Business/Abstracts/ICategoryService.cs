using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Category GetById(int CategoryId);
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int CategoryId);
    }
}
