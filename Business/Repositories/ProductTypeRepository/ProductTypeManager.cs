using Business.Repositories.CategoryRepository.Constants;
using Business.Repositories.CategoryRepository.Validation;
using Business.Repositories.ProductTypeRepository.Constants;
using Business.Repositories.ProductTypeRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.ProductTypeRepository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.ProductTypeRepository
{
    public class ProductTypeManager : IProductTypeService
    {
        private readonly IProductTypeDal _productTypeDal;
        public ProductTypeManager(IProductTypeDal productTypeDal) 
        {
            _productTypeDal = productTypeDal;
        }

        [ValidationAspect(typeof(ProductTypeValidator))]
        [RemoveCacheAspect("IProductTypeService.Get")]
        public async Task<IResult> Add(ProductType productType)
        {
           await _productTypeDal.Add(productType);
            return new SuccessResult(ProductTypeMessages.AddedProductType);
        }

        [RemoveCacheAspect("IProductTypeService.Get")]
        public async Task<IResult> Delete(ProductType productType)
        {
            await _productTypeDal.Delete(productType);
            return new SuccessResult(ProductTypeMessages.DeletedProdyctType);
        }

        public async Task<IDataResult<ProductType>> GetById(int id)
        {
            return new SuccessDataResult<ProductType>(await _productTypeDal.Get(p => p.Id == id));
        }

        public async Task<ProductType> GetFirst()
        {
            return await _productTypeDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<ProductType>>> GetList()
        {
            return new SuccessDataResult<List<ProductType>>(await _productTypeDal.GetAll());
        }

        [ValidationAspect(typeof(CategoryValidator))]
        [RemoveCacheAspect("IProductTypeService.Get")]
        public async Task<IResult> Update(ProductType productType)
        {
            await _productTypeDal.Update(productType);
            return new SuccessResult(ProductTypeMessages.UpdatedProductType);
        }
    }
}
