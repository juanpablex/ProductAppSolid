using Business.Aspects.Secured;
using Business.Repositories.StoreRepository.Constants;
using Business.Repositories.StoreRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.StoreRepository;
using Entities.Concrete;

namespace Business.Repositories.StoreRepository
{
    public class StoreManager : IStoreService
    {
        private readonly IStoreDal _storeDal;
        public StoreManager(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(StoreValidator))]
        [RemoveCacheAspect("IStoreService.Get")]
        public async Task<IResult> Add(Store store)
        {
            await _storeDal.Add(store);
            return new SuccessResult(StoreMessages.AddedStore);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IStoreService.Get")]
        public async Task<IResult> Delete(Store store)
        {
            await _storeDal.Delete(store);
            return new SuccessResult(StoreMessages.DeletedStore);
        }

        public async Task<IDataResult<Store>> GetById(int id)
        {
            return new SuccessDataResult<Store>(await _storeDal.Get(p => p.Id == id));
        }

        public async Task<Store> GetFirst()
        {
            return await _storeDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Store>>> GetList()
        {
            return new SuccessDataResult<List<Store>>(await _storeDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(StoreValidator))]
        [RemoveCacheAspect("IStoreService.Get")]
        public async Task<IResult> Update(Store store)
        {
            await _storeDal.Update(store);
            return new SuccessResult(StoreMessages.UpdatedStore);
        }
    }
}
