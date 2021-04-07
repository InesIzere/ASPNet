using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3._1.Models
{
    public partial class Battery
    {
        public Battery()
        {
            Column = new HashSet<Column>();
            Intervention = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public long? BuildingId { get; set; }
        public string Status { get; set; }
        public DateTime? DateCommissioning { get; set; }
        public DateTime? DateLastInspection { get; set; }
        public string CertificateOfOperations { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public string BatteryType { get; set; }

        public virtual Building Building { get; set; }
        public virtual ICollection<Column> Column { get; set; }
        public virtual ICollection<Intervention> Intervention { get; set; }
    }
}
