using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3._1.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Intervention = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public long? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Intervention> Intervention { get; set; }
    }
}
