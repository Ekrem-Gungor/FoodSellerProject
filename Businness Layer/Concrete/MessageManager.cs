using Data_Access_Layer.Abstract;
using Entitiy_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messagedal;

        public MessageManager(IMessageDal messageDal)
        {
            _messagedal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _messagedal.Get(x=> x.MessageID == id);
        }

        public List<Message> GetListInbox()
        {
            return _messagedal.List(x=> x.ReceiverMail == "admin@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            return _messagedal.List(x => x.SenderMail == "admin@gmail.com");
        }

        public void messageAdd(Message message)
        {
            _messagedal.Insert(message);
        }

        public void messageDelete(Message message)
        {
            _messagedal.Delete(message);
        }

        public void messageUpdate(Message message)
        {
            _messagedal.Update(message);
        }
    }
}
