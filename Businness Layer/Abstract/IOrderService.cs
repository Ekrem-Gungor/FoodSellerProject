using Entitiy_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Abstract
{
    public interface IOrderService
    {
        List<Orders> GetList();
        List<Orders> GetListByOrderID(int id);
        void OrderAdd(Orders order);
        Orders GetByID(int id);
        void OrderDelete(Orders order);
        void OrderUpdate(Orders order);
    }
}
