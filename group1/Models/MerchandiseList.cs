using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace group1.Models
{
    public class MerchandiseList
    {
        public virtual int MerchandiseListId { get; set; }
        [Required]
        public virtual string Item { get; set; }
        [Required]
        public virtual string Size { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public virtual Decimal Price { get; set; }
        [Required]
        public virtual int Quanity { get; set; }
    }
}
