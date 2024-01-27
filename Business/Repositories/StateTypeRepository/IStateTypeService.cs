using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.StateTypeRepository
{
    public interface IStateTypeService
    {
        Task<IResult> Add(StateType statetype);
        Task<IResult> Update(StateType statetype);
        Task<IResult> Delete(StateType statetype);
        Task<IDataResult<List<StateType>>> GetList();
        Task<IDataResult<StateType>> GetById(int id);
        Task<StateType> GetFirst();
    }
}
