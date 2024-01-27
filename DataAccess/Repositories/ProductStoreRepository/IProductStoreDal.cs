using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ProductStoreRepository
{
    public interface IProductStoreDal:IEntityRepository<ProductStore>
    {
    }
}