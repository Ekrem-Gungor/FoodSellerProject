using Businness_Layer.Abstract;
using Data_Access_Layer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;

namespace Businness_Layer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void contactAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void contactDelete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public void contactUpdate(Contact contact)
        {
            _contactDal.Update(contact);
        }

        public Contact GetByID(int id)
        {
            return _contactDal.Get(x => x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }
    }
}
