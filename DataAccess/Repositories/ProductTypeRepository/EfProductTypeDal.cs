using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ProductTypeRepository
{
    public class EfProductTypeDal : EfEntityRepositoryBase<ProductType,SimpleContextDb>, IProductTypeDal
    {
    }
}
