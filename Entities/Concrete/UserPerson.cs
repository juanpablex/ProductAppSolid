using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserPerson
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
