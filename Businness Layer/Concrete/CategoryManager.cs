using Businness_Layer.Abstract;
using Data_Access_Layer.Abstract;
using Data_Access_Layer.Concrete.Repositories;
using Entitiy_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void categoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public void categoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }

        public void categoryUpdate(Category category)
        {
            _categorydal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categorydal.Get(x=> x.CategoryID==id);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }

        
       
    }
}
