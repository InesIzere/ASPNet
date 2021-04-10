using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3._1.Models
{
    public class Customer
    {


        public Customer()
        {
            Building = new HashSet<Building>();
            Intervention = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string FullNameCompanyContact { get; set; }
        public string CompanyContactPhone { get; set; }
        public string CompanyContactEmail { get; set; }
        public string CompanyDescription { get; set; }
        public string FullNameServiceTechnicalAuthority { get; set; }
        public string TechnicalAuthorityPhone { get; set; }
        public string TechnicalAuthorityEmail { get; set; }
        public long? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Building> Building { get; set; }
        public virtual ICollection<Intervention> Intervention { get; set; }
        public List<Building> buildings { get; set; }
    }
}
