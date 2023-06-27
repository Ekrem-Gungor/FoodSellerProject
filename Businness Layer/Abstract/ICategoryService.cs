using Entitiy_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void categoryAdd(Category category);
        Category GetByID(int id);
        void categoryDelete(Category category);
        void categoryUpdate(Category category);


    }
}
