using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace group1.Models
{
    public class DisscusionBoard
    {
        public virtual int Id { get; set; }
        [Required]
        public virtual string Comment { get; set; }

        public virtual DateTime PostedAt { get; set; } = DateTime.Now;
    }
}
