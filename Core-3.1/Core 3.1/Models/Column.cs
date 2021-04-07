using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3._1.Models
{
    public partial class Column
    {
        public Column()
        {
            Elevator = new HashSet<Elevator>();
            Intervention = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public long? BatteryId { get; set; }
        public int? NumberOfFloorsServed { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public string ColumnType { get; set; }

        public virtual Battery Battery { get; set; }
        public virtual ICollection<Elevator> Elevator { get; set; }
        public virtual ICollection<Intervention> Intervention { get; set; }
    }

}

