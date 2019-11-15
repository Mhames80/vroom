using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace group1.Models
{
    public class MerchandiseList
    {
        public virtual int Id { get; set; }
        public virtual string Item { get; set; }
        public virtual string Size { get; set; }
        [DataType(DataType.Currency)]
        public virtual Decimal Price { get; set; }
        public virtual int Quanity { get; set; }
    }
}
