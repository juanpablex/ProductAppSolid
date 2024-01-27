using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.StoreRepository
{
    public interface IStoreService
    {
        Task<IResult> Add(Store store);
        Task<IResult> Update(Store store);
        Task<IResult> Delete(Store store);
        Task<IDataResult<List<Store>>> GetList();
        Task<IDataResult<Store>> GetById(int id);
        Task<Store> GetFirst();
    }
}
