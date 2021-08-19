using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class EntityBase
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; } 

        [Column(Order = 1200)]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        [Column(Order = 1300)]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;

        [Column(Order = 1400)]
        public Guid? CreatedBy { get; set; } 

        [Column(Order = 1500)]
        public Guid? UpdatedBy { get; set; } 

    }
}
