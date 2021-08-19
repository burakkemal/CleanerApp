using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class AdministratorHospital : EntityBase
    {
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Hospital")]
        public Guid HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }


    }

}
