using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.PrivilegeRepository
{
    public interface IPrivilegeService
    {
        Task<IResult> Add(Privilege privilege);
        Task<IResult> Update(Privilege privilege);
        Task<IResult> Delete(Privilege privilege);
        Task<IDataResult<List<Privilege>>> GetList();
        Task<IDataResult<Privilege>> GetById(int id);
        Task<Privilege> GetFirst();
    }
}
