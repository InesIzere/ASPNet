using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3._1.Models
{
    public partial class BuildingDetails
    {
        public long Id { get; set; }
        public string InformationKey { get; set; }
        public string Value { get; set; }
        public long? BuildingId { get; set; }

        public virtual Building Building { get; set; }
    }
}
