using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        IList<Category> GetList();
        Category GetById(int id);
        void Add(Category category);

        void Update(Category category);

        void Delete(Category category);
    }
}
