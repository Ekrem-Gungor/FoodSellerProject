using Businness_Layer.Abstract;
using Data_Access_Layer.Abstract;
using EntitiyLayer.Concrete;
using System.Collections.Generic;

namespace Businness_Layer.Concrete
{
    public class AboutManager : IAboutService
	{
		IAboutDal _aboutdal;

		public AboutManager(IAboutDal aboutdal)
		{
			_aboutdal = aboutdal;
		}

		public void AboutAdd(About about)
		{
            _aboutdal.Insert(about);
        }

		public void AboutDelete(About about)
		{
			_aboutdal.Delete(about);
		}

		public void AboutUpdate(About about)
		{
            _aboutdal.Update(about);
        }

		public About GetByID(int id)
		{
			return _aboutdal.Get(x => x.AboutID == id);
		}

		public List<About> GetList()
		{
			return _aboutdal.List();
		}
	}
}
