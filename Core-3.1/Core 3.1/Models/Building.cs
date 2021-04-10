using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3._1.Models
{
    public partial class Building
    {
       

        public Building()
        {
            Battery = new HashSet<Battery>();
            BuildingDetails = new HashSet<BuildingDetails>();
            Intervention = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public string AddressBuilding { get; set; }
        public string FullNameAdministrator { get; set; }
        public string EmailAdministrator { get; set; }
        public string PhoneAdministrator { get; set; }
        public string FullNameTechnicalContactBuilding { get; set; }
        public string TechnicalContactBuildingEmail { get; set; }
        public string TechnicalContactBuildingPhone { get; set; }
        public long? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Battery> Battery { get; set; }
        public virtual ICollection<BuildingDetails> BuildingDetails { get; set; }
        public virtual ICollection<Intervention> Intervention { get; set; }

        public List<Battery> batteries { get; set; }
    }
}
