using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.ProductStoreRepository
{
    public interface IProductStoreService
    {
        Task<IResult> Add(ProductStore productstore);
        Task<IResult> Update(ProductStore productstore);
        Task<IResult> Delete(ProductStore productstore);
        Task<IDataResult<List<ProductStore>>> GetList();
        Task<IDataResult<ProductStore>> GetById(int id);
        Task<ProductStore> GetFirst();
    }
}
