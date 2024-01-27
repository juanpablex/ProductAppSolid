using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Measurement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int TypeId { get; set; }
        public MeasurementType Type { get; set; }
        public double ConversionFactor { get; set; }
    }
}
