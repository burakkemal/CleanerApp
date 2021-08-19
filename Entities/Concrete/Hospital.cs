using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Hospital:EntityBase
    {
        public string Name { get; set; }
        public string Adress { get; set; }

        public ICollection<AdministratorHospital> AdministratorHospitals { get; set; }
        public ICollection<Location> Locations{ get; set; }
        public ICollection<HospitalIsActive> HospitalIsActives { get; set; }
    }
}
