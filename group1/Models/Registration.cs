using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace group1.Models
{
    public class Registration
    { 
        public virtual int Id { get; set; }

        [Required]
        public virtual String FirstName { get; set; }
        [Required]
        public virtual String LastName { get; set; }
        [Required]
        public virtual String StreetNumber { get; set; }
        [Required]
        public virtual String StreetName { get; set; }
        [Required]
        public virtual String City { get; set; }
        [Required]
        public virtual String Province { get; set; }
        [Required]
        public virtual String PostalCode { get; set; }
        [Required]
        public virtual String Country { get; set; }
    }
}
