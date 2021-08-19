using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class LocationObject:EntityBase
    {
        [ForeignKey("Location")]
        public Guid LocationId { get; set; }

        public virtual Location Location { get; set; }

        [ForeignKey("Object")]
        public Guid ObjectId { get; set; }
        public virtual Object Object { get; set; }


    }
}
