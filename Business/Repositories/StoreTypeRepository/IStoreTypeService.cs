using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.StoreTypeRepository
{
    public interface IStoreTypeService
    {
        Task<IResult> Add(StoreType storetype);
        Task<IResult> Update(StoreType storetype);
        Task<IResult> Delete(StoreType storetype);
        Task<IDataResult<List<StoreType>>> GetList();
        Task<IDataResult<StoreType>> GetById(int id);
        Task<StoreType> GetFirst();
    }
}
