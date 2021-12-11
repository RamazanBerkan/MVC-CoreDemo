using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EnitityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    public class EfCategoryRepository:GenericRepository<Category>, ICategoryDal
    {
    }
}
