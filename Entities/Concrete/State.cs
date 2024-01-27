using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public StateType Type { get; set; }
    }
}
