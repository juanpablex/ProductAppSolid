using Business.Aspects.Secured;
using Business.Repositories.MeasurementRepository.Constants;
using Business.Repositories.MeasurementRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.MeasurementRepository;
using Entities.Concrete;

namespace Business.Repositories.MeasurementRepository
{
    public class MeasurementManager : IMeasurementService
    {
        private readonly IMeasurementDal _measurementDal;
        public MeasurementManager(IMeasurementDal measurementDal)
        {
            _measurementDal = measurementDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(MeasurementValidator))]
        [RemoveCacheAspect("IMeasurementService.Get")]
        public async Task<IResult> Add(Measurement measurement)
        {
            await _measurementDal.Add(measurement);
            return new SuccessResult(MeasurementMessages.AddedMeasurement);
        }

        //[SecuredAspect()]
        [RemoveCacheAspect("IMeasurementService.Get")]
        public async Task<IResult> Delete(Measurement measurement)
        {
            await _measurementDal.Delete(measurement);
            return new SuccessResult(MeasurementMessages.DeletedMeasurement);
        }

        public async Task<IDataResult<Measurement>> GetById(int id)
        {
            return new SuccessDataResult<Measurement>(await _measurementDal.Get(p => p.Id == id));
        }

        public async Task<Measurement> GetFirst()
        {
            return await _measurementDal.GetFirst();
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Measurement>>> GetList()
        {
            return new SuccessDataResult<List<Measurement>>(await _measurementDal.GetAll());
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(MeasurementValidator))]
        [RemoveCacheAspect("IMeasurementService.Get")]
        public async Task<IResult> Update(Measurement measurement)
        {
            await _measurementDal.Update(measurement);
            return new SuccessResult(MeasurementMessages.UpdatedMeasurement);
        }
    }
}
