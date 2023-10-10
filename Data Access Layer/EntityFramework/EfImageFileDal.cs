using Data_Access_Layer.Abstract;
using Data_Access_Layer.Concrete.Repositories;
using Entitiy_Layer.Concrete;

namespace Data_Access_Layer.EntityFramework
{
    public class EfImageFileDal : GenericRepository<ImageFile>, IImageFileDal
    {
    }
}
