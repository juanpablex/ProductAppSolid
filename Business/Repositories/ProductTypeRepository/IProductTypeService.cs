using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.ProductTypeRepository
{
    public interface IProductTypeService
    {
        Task<IResult> Add(ProductType productType);
        Task<IResult> Update(ProductType productType);
        Task<IResult> Delete(ProductType productType);
        Task<IDataResult<List<ProductType>>> GetList();
        Task<IDataResult<ProductType>> GetById(int id);
        Task<ProductType> GetFirst();
    }
}
