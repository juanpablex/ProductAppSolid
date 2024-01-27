using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public int TypeId { get; set; }
        public ProductType Type { get; set; }
        public double Price { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public int MeasurementId { get; set; }
        public Measurement Measurement { get; set; }
        public double Stock { get; set; }
    }
}
