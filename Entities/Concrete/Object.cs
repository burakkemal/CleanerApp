using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Object : EntityBase
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public ICollection<LocationObject> LocationObjects { get; set; }
    }
}
