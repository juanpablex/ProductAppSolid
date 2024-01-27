using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.MeasurementTypeRepository
{
    public interface IMeasurementTypeService
    {
        Task<IResult> Add(MeasurementType measurementtype);
        Task<IResult> Update(MeasurementType measurementtype);
        Task<IResult> Delete(MeasurementType measurementtype);
        Task<IDataResult<List<MeasurementType>>> GetList();
        Task<IDataResult<MeasurementType>> GetById(int id);
        Task<MeasurementType> GetFirst();
    }
}
