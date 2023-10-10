using Data_Access_Layer.Abstract;
using Data_Access_Layer.Concrete.Repositories;
using EntitiyLayer.Concrete;

namespace Data_Access_Layer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
