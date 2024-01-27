using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.PersonRepository
{
    public interface IPersonService
    {
        Task<IResult> Add(Person person);
        Task<IResult> Update(Person person);
        Task<IResult> Delete(Person person);
        Task<IDataResult<List<Person>>> GetList();
        Task<IDataResult<Person>> GetById(int id);
        Task<Person> GetFirst();
    }
}
