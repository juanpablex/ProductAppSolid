using Business.Aspects.Secured;
using Business.Repositories.StoreTypeRepository.Constants;
using Business.Repositories.StoreTypeRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.StoreTypeRepository;
using Entities.Concrete;

namespace Business.Repositories.StoreTypeRepository
{
    public class StoreTypeManager : IStoreTypeService
    {
        private readonly IStoreTypeDal _storetypeDal;
        public StoreTypeManager(IStoreTypeDal storetypeDal)
        {
            _storetypeDal = storetypeDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(StoreTypeValidator))]
        [RemoveCacheAspect("IStoreTypeService.Get")]
        public async Task<IResult> Add(StoreType storetype)
        {
            await _storetypeDal.Add(storetype);
            return new SuccessResult(StoreTypeMessages.AddedStoreType);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IStoreTypeService.Get")]
        public async Task<IResult> Delete(StoreType storetype)
        {
            await _storetypeDal.Delete(storetype);
            return new SuccessResult(StoreTypeMessages.DeletedStoreType);
        }

        public async Task<IDataResult<StoreType>> GetById(int id)
        {
            return new SuccessDataResult<StoreType>(await _storetypeDal.Get(p => p.Id == id));
        }

        public async Task<StoreType> GetFirst()
        {
            return await _storetypeDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<StoreType>>> GetList()
        {
            return new SuccessDataResult<List<StoreType>>(await _storetypeDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(StoreTypeValidator))]
        [RemoveCacheAspect("IStoreTypeService.Get")]
        public async Task<IResult> Update(StoreType storetype)
        {
            await _storetypeDal.Update(storetype);
            return new SuccessResult(StoreTypeMessages.UpdatedStoreType);
        }
    }
}
