using Business.Aspects.Secured;
using Business.Repositories.StateTypeRepository.Constants;
using Business.Repositories.StateTypeRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.StateTypeRepository;
using Entities.Concrete;

namespace Business.Repositories.StateTypeRepository
{
    public class StateTypeManager : IStateTypeService
    {
        private readonly IStateTypeDal _statetypeDal;
        public StateTypeManager(IStateTypeDal statetypeDal)
        {
            _statetypeDal = statetypeDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(StateTypeValidator))]
        [RemoveCacheAspect("IStateTypeService.Get")]
        public async Task<IResult> Add(StateType statetype)
        {
            await _statetypeDal.Add(statetype);
            return new SuccessResult(StateTypeMessages.AddedStateType);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IStateTypeService.Get")]
        public async Task<IResult> Delete(StateType statetype)
        {
            await _statetypeDal.Delete(statetype);
            return new SuccessResult(StateTypeMessages.DeletedStateType);
        }

        public async Task<IDataResult<StateType>> GetById(int id)
        {
            return new SuccessDataResult<StateType>(await _statetypeDal.Get(p => p.Id == id));
        }

        public async Task<StateType> GetFirst()
        {
            return await _statetypeDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<StateType>>> GetList()
        {
            return new SuccessDataResult<List<StateType>>(await _statetypeDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(StateTypeValidator))]
        [RemoveCacheAspect("IStateTypeService.Get")]
        public async Task<IResult> Update(StateType statetype)
        {
            await _statetypeDal.Update(statetype);
            return new SuccessResult(StateTypeMessages.UpdatedStateType);
        }
    }
}
