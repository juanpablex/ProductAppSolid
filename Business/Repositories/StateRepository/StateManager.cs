using Business.Aspects.Secured;
using Business.Repositories.StateRepository.Constants;
using Business.Repositories.StateRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.StateRepository;
using Entities.Concrete;

namespace Business.Repositories.StateRepository
{
    public class StateManager : IStateService
    {
        private readonly IStateDal _stateDal;
        public StateManager(IStateDal stateDal)
        {
            _stateDal = stateDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(StateValidator))]
        [RemoveCacheAspect("IStateService.Get")]
        public async Task<IResult> Add(State state)
        {
            await _stateDal.Add(state);
            return new SuccessResult(StateMessages.AddedState);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IStateService.Get")]
        public async Task<IResult> Delete(State state)
        {
            await _stateDal.Delete(state);
            return new SuccessResult(StateMessages.DeletedState);
        }

        public async Task<IDataResult<State>> GetById(int id)
        {
            return new SuccessDataResult<State>(await _stateDal.Get(p => p.Id == id));
        }

        public async Task<State> GetFirst()
        {
            return await _stateDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<State>>> GetList()
        {
            return new SuccessDataResult<List<State>>(await _stateDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(StateValidator))]
        [RemoveCacheAspect("IStateService.Get")]
        public async Task<IResult> Update(State state)
        {
            await _stateDal.Update(state);
            return new SuccessResult(StateMessages.UpdatedState);
        }
    }
}
