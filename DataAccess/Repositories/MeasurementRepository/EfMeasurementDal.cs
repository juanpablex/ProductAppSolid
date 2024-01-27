using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.MeasurementRepository
{
    public class EfMeasurementDal:EfEntityRepositoryBase<Measurement,SimpleContextDb>,IMeasurementDal
    {
    }
}