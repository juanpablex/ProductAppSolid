using Business.Aspects.Secured;
using Business.Repositories.PrivilegeRepository.Constants;
using Business.Repositories.PrivilegeRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.PrivilegeRepository;
using Entities.Concrete;

namespace Business.Repositories.PrivilegeRepository
{
    public class PrivilegeManager : IPrivilegeService
    {
        private readonly IPrivilegeDal _privilegeDal;
        public PrivilegeManager(IPrivilegeDal privilegeDal)
        {
            _privilegeDal = privilegeDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(PrivilegeValidator))]
        [RemoveCacheAspect("IPrivilegeService.Get")]
        public async Task<IResult> Add(Privilege privilege)
        {
            await _privilegeDal.Add(privilege);
            return new SuccessResult(PrivilegeMessages.AddedPrivilege);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IPrivilegeService.Get")]
        public async Task<IResult> Delete(Privilege privilege)
        {
            await _privilegeDal.Delete(privilege);
            return new SuccessResult(PrivilegeMessages.DeletedPrivilege);
        }

        public async Task<IDataResult<Privilege>> GetById(int id)
        {
            return new SuccessDataResult<Privilege>(await _privilegeDal.Get(p => p.Id == id));
        }

        public async Task<Privilege> GetFirst()
        {
            return await _privilegeDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Privilege>>> GetList()
        {
            return new SuccessDataResult<List<Privilege>>(await _privilegeDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(PrivilegeValidator))]
        [RemoveCacheAspect("IPrivilegeService.Get")]
        public async Task<IResult> Update(Privilege privilege)
        {
            await _privilegeDal.Update(privilege);
            return new SuccessResult(PrivilegeMessages.UpdatedPrivilege);
        }
    }
}
