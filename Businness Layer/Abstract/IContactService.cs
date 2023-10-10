using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();
        void contactAdd(Contact contact);
        Contact GetByID(int id);
        void contactDelete(Contact contact);
        void contactUpdate(Contact contact);
    }
}
