using EntitiyLayer.Concrete;
using System.Collections.Generic;

namespace Businness_Layer.Abstract
{
    public interface IAboutService
	{
		List<About> GetList();
		void AboutAdd(About about);
		About GetByID(int id);
		void AboutDelete(About about);
		void AboutUpdate(About about);
	}
}
