using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace group1.Models
{
    public class Registration
    { 
        public virtual int Id { get; set; }


        public virtual String FirstName { get; set; }
        public virtual String LastName { get; set; }
        public virtual String StreetNumber { get; set; }
        public virtual String StreetName { get; set; }
        public virtual String City { get; set; }
        public virtual String Province { get; set; }
        public virtual String PostalCode { get; set; }
        public virtual String Country { get; set; }
    }
}
