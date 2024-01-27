using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.StateRepository
{
    public interface IStateService
    {
        Task<IResult> Add(State state);
        Task<IResult> Update(State state);
        Task<IResult> Delete(State state);
        Task<IDataResult<List<State>>> GetList();
        Task<IDataResult<State>> GetById(int id);
        Task<State> GetFirst();
    }
}
