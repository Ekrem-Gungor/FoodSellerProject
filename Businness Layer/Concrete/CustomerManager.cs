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
    public class CustomerManager : IContacaService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void CustAdd(Customer customer)
        {
            _customerDal.Insert(customer);
        }

        public void CustDelete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public void CustUpdate(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public Customer GetByID(int id)
        {
            return _customerDal.Get(x => x.CustomerID == id);
        }

        public List<Customer> GetList()
        {
            return _customerDal.List();
        }
    }
}
