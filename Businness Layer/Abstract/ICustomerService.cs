using Entitiy_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetList();
        void CustAdd(Customer customer);
        void CustDelete(Customer customer);
        void CustUpdate(Customer customer);
        Customer GetByID(int id);
    }
}
