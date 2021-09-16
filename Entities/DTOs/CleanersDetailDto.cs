using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CleanersDetailDto
    {
        public Guid CleanerId { get; set; }
        public string CleanerName { get; set; }
        public string CleanerSurname { get; set; }
        public string CleanerEmail { get; set; }
        public int Gsm { get; set; }
        
    }
}
