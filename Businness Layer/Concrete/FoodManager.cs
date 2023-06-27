using Businness_Layer.Abstract;
using Data_Access_Layer.Abstract;
using Entitiy_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class FoodManager : IFoodService
    {
        IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public void foodAdd(Foods food)
        {
            _foodDal.Insert(food);
        }

        public void foodDelete(Foods food)
        {
            _foodDal.Delete(food);
        }

        public void foodUpdate(Foods food)
        {
            _foodDal.Update(food);
        }

        public Foods GetByID(int id)
        {
            return _foodDal.Get(x=> x.FoodID==id);
        }

        public List<Foods> GetList()
        {
            return _foodDal.List();
        }
    }
}
