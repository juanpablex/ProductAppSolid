using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Phone { get; set; }
        public string Nit { get; set; }
        public string Url { get; set; }
        public int TypeId { get; set; }
        public StoreType Type { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
