using Business.Aspects.Secured;
using Business.Repositories.ProductStoreRepository.Constants;
using Business.Repositories.ProductStoreRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.ProductStoreRepository;
using Entities.Concrete;

namespace Business.Repositories.ProductStoreRepository
{
    public class ProductStoreManager : IProductStoreService
    {
        private readonly IProductStoreDal _productstoreDal;
        public ProductStoreManager(IProductStoreDal productstoreDal)
        {
            _productstoreDal = productstoreDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(ProductStoreValidator))]
        [RemoveCacheAspect("IProductStoreService.Get")]
        public async Task<IResult> Add(ProductStore productstore)
        {
            await _productstoreDal.Add(productstore);
            return new SuccessResult(ProductStoreMessages.AddedProductStore);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IProductStoreService.Get")]
        public async Task<IResult> Delete(ProductStore productstore)
        {
            await _productstoreDal.Delete(productstore);
            return new SuccessResult(ProductStoreMessages.DeletedProductStore);
        }

        public async Task<IDataResult<ProductStore>> GetById(int id)
        {
            return new SuccessDataResult<ProductStore>(await _productstoreDal.Get(p => p.Id == id));
        }

        public async Task<ProductStore> GetFirst()
        {
            return await _productstoreDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<ProductStore>>> GetList()
        {
            return new SuccessDataResult<List<ProductStore>>(await _productstoreDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(ProductStoreValidator))]
        [RemoveCacheAspect("IProductStoreService.Get")]
        public async Task<IResult> Update(ProductStore productstore)
        {
            await _productstoreDal.Update(productstore);
            return new SuccessResult(ProductStoreMessages.UpdatedProductStore);
        }
    }
}
