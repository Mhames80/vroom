using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace group1.Models
{
    public class CarPartList
    {

        public virtual int Id { get; set; }
        public virtual string   Part{get; set; }
        public virtual string Model{ get; set; }
        [DataType(DataType.Currency)]
        public virtual Decimal Price { get; set; }
        public virtual int Quanity { get; set; }

    }
}
