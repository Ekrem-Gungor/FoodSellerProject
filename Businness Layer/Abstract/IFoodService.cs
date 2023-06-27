using Entitiy_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Abstract
{
    public interface IFoodService
    {
        List<Foods> GetList();
        void foodAdd(Foods food);
        Foods GetByID(int id);
        void foodDelete(Foods food);
        void foodUpdate(Foods food);
    }
}
