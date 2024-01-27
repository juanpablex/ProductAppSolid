using Business.Aspects.Secured;
using Business.Repositories.MeasurementTypeRepository.Constants;
using Business.Repositories.MeasurementTypeRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.MeasurementTypeRepository;
using Entities.Concrete;

namespace Business.Repositories.MeasurementTypeRepository
{
    public class MeasurementTypeManager : IMeasurementTypeService
    {
        private readonly IMeasurementTypeDal _measurementtypeDal;
        public MeasurementTypeManager(IMeasurementTypeDal measurementtypeDal)
        {
            _measurementtypeDal = measurementtypeDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(MeasurementTypeValidator))]
        [RemoveCacheAspect("IMeasurementTypeService.Get")]
        public async Task<IResult> Add(MeasurementType measurementtype)
        {
            await _measurementtypeDal.Add(measurementtype);
            return new SuccessResult(MeasurementTypeMessages.AddedMeasurementType);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IMeasurementTypeService.Get")]
        public async Task<IResult> Delete(MeasurementType measurementtype)
        {
            await _measurementtypeDal.Delete(measurementtype);
            return new SuccessResult(MeasurementTypeMessages.DeletedMeasurementType);
        }

        public async Task<IDataResult<MeasurementType>> GetById(int id)
        {
            return new SuccessDataResult<MeasurementType>(await _measurementtypeDal.Get(p => p.Id == id));
        }

        public async Task<MeasurementType> GetFirst()
        {
            return await _measurementtypeDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<MeasurementType>>> GetList()
        {
            return new SuccessDataResult<List<MeasurementType>>(await _measurementtypeDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(MeasurementTypeValidator))]
        [RemoveCacheAspect("IMeasurementTypeService.Get")]
        public async Task<IResult> Update(MeasurementType measurementtype)
        {
            await _measurementtypeDal.Update(measurementtype);
            return new SuccessResult(MeasurementTypeMessages.UpdatedMeasurementType);
        }
    }
}
