using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Location : EntityBase
    {
        public string Name { get; set; }

        [ForeignKey("Cleaner")]
        public Guid CleanerId { get; set; } //foreignkey alacak
        public virtual Cleaner Cleaner { get; set; }


        [ForeignKey("Hospital")]
        public Guid HospitalId { get; set; } //foreign key alacak

        public virtual Hospital Hospital { get; set; }

        public int Number { get; set; }

        public ICollection<LocationObject> LocationObjects { get; set; }
    }
}
