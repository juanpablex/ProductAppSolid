using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.MeasurementRepository
{
    public interface IMeasurementService
    {
        Task<IResult> Add(Measurement measurement);
        Task<IResult> Update(Measurement measurement);
        Task<IResult> Delete(Measurement measurement);
        Task<IDataResult<List<Measurement>>> GetList();
        Task<IDataResult<Measurement>> GetById(int id);
        Task<Measurement> GetFirst();
    }
}
