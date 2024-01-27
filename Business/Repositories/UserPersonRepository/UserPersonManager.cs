using Business.Aspects.Secured;
using Business.Repositories.UserPersonRepository.Constants;
using Business.Repositories.UserPersonRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.UserPersonRepository;
using Entities.Concrete;

namespace Business.Repositories.UserPersonRepository
{
    public class UserPersonManager : IUserPersonService
    {
        private readonly IUserPersonDal _userpersonDal;
        public UserPersonManager(IUserPersonDal userpersonDal)
        {
            _userpersonDal = userpersonDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(UserPersonValidator))]
        [RemoveCacheAspect("IUserPersonService.Get")]
        public async Task<IResult> Add(UserPerson userperson)
        {
            await _userpersonDal.Add(userperson);
            return new SuccessResult(UserPersonMessages.AddedUserPerson);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IUserPersonService.Get")]
        public async Task<IResult> Delete(UserPerson userperson)
        {
            await _userpersonDal.Delete(userperson);
            return new SuccessResult(UserPersonMessages.DeletedUserPerson);
        }

        public async Task<IDataResult<UserPerson>> GetById(int id)
        {
            return new SuccessDataResult<UserPerson>(await _userpersonDal.Get(p => p.Id == id));
        }

        public async Task<UserPerson> GetFirst()
        {
            return await _userpersonDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<UserPerson>>> GetList()
        {
            return new SuccessDataResult<List<UserPerson>>(await _userpersonDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(UserPersonValidator))]
        [RemoveCacheAspect("IUserPersonService.Get")]
        public async Task<IResult> Update(UserPerson userperson)
        {
            await _userpersonDal.Update(userperson);
            return new SuccessResult(UserPersonMessages.UpdatedUserPerson);
        }
    }
}
