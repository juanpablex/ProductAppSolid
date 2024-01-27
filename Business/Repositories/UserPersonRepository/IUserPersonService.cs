using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.UserPersonRepository
{
    public interface IUserPersonService
    {
        Task<IResult> Add(UserPerson userperson);
        Task<IResult> Update(UserPerson userperson);
        Task<IResult> Delete(UserPerson userperson);
        Task<IDataResult<List<UserPerson>>> GetList();
        Task<IDataResult<UserPerson>> GetById(int id);
        Task<UserPerson> GetFirst();
    }
}
