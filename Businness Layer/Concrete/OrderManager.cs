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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderdal;

        public OrderManager(IOrderDal orderdal)
        {
            _orderdal = orderdal;
        }

        public Orders GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetList()
        {
            throw new NotImplementedException();
        }

		public List<Orders> GetListByOrderID(int id)
        {
            return _orderdal.List(x => x.FoodID == id);
        }

        public void OrderAdd(Orders order)
        {
            throw new NotImplementedException();
        }

        public void OrderDelete(Orders order)
        {
            throw new NotImplementedException();
        }

        public void OrderUpdate(Orders order)
        {
            throw new NotImplementedException();
        }

    }
}
