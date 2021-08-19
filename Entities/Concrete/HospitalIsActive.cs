using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HospitalIsActive : EntityBase
    {
        [ForeignKey("Hospital")]
        public Guid HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ActiveDate { get; set; }
    }
}
