using Data_Access_Layer.Abstract;
using Data_Access_Layer.Concrete.Repositories;
using Entitiy_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {

    }
}
