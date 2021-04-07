using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3._1.Models
{
    public partial class Elevator
    {
        public Elevator()
        {
            Intervention = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }
        public DateTime DateOfCommissioning { get; set; }
        public DateTime DateOfLastInspection { get; set; }
        public string CertificateOfInspection { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public long? ColumnId { get; set; }
        public string ElevatorType { get; set; }

        public virtual Column Column { get; set; }
        public virtual ICollection<Intervention> Intervention { get; set; }
    }
}
