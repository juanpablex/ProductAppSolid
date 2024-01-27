using Business.Aspects.Secured;
using Business.Repositories.PersonRepository.Constants;
using Business.Repositories.PersonRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.PersonRepository;
using Entities.Concrete;

namespace Business.Repositories.PersonRepository
{
    public class PersonManager : IPersonService
    {
        private readonly IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(PersonValidator))]
        [RemoveCacheAspect("IPersonService.Get")]
        public async Task<IResult> Add(Person person)
        {
            await _personDal.Add(person);
            return new SuccessResult(PersonMessages.AddedPerson);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IPersonService.Get")]
        public async Task<IResult> Delete(Person person)
        {
            await _personDal.Delete(person);
            return new SuccessResult(PersonMessages.DeletedPerson);
        }

        public async Task<IDataResult<Person>> GetById(int id)
        {
            return new SuccessDataResult<Person>(await _personDal.Get(p => p.Id == id));
        }

        public async Task<Person> GetFirst()
        {
            return await _personDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Person>>> GetList()
        {
            return new SuccessDataResult<List<Person>>(await _personDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(PersonValidator))]
        [RemoveCacheAspect("IPersonService.Get")]
        public async Task<IResult> Update(Person person)
        {
            await _personDal.Update(person);
            return new SuccessResult(PersonMessages.UpdatedPerson);
        }
    }
}
