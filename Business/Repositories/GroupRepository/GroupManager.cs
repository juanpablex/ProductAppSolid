using Business.Aspects.Secured;
using Business.Repositories.GroupRepository.Constants;
using Business.Repositories.GroupRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.GroupRepository;
using Entities.Concrete;

namespace Business.Repositories.GroupRepository
{
    public class GroupManager : IGroupService
    {
        private readonly IGroupDal _groupDal;
        public GroupManager(IGroupDal groupDal)
        {
            _groupDal = groupDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(GroupValidator))]
        [RemoveCacheAspect("IGroupService.Get")]
        public async Task<IResult> Add(Group group)
        {
            await _groupDal.Add(group);
            return new SuccessResult(GroupMessages.AddedGroup);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IGroupService.Get")]
        public async Task<IResult> Delete(Group group)
        {
            await _groupDal.Delete(group);
            return new SuccessResult(GroupMessages.DeletedGroup);
        }

        public async Task<IDataResult<Group>> GetById(int id)
        {
            return new SuccessDataResult<Group>(await _groupDal.Get(p => p.Id == id));
        }

        public async Task<Group> GetFirst()
        {
            return await _groupDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Group>>> GetList()
        {
            return new SuccessDataResult<List<Group>>(await _groupDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(GroupValidator))]
        [RemoveCacheAspect("IGroupService.Get")]
        public async Task<IResult> Update(Group group)
        {
            await _groupDal.Update(group);
            return new SuccessResult(GroupMessages.UpdatedGroup);
        }
    }
}
