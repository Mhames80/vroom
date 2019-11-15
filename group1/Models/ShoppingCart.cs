using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace group1.Models
{
    public class Cart
    {

        public virtual int Id { get; set; }
        public virtual List<CarPartList> CarPartList { get; set; }
        public virtual List<MerchandiseList> MerchandiseLists { get; set; }
    }
}
