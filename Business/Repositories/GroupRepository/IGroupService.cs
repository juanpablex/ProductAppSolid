using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.GroupRepository
{
    public interface IGroupService
    {
        Task<IResult> Add(Group group);
        Task<IResult> Update(Group group);
        Task<IResult> Delete(Group group);
        Task<IDataResult<List<Group>>> GetList();
        Task<IDataResult<Group>> GetById(int id);
        Task<Group> GetFirst();
    }
}
