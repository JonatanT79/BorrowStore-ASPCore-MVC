using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class ProductCopies
    {
        [Key]
        public string SerialNumber { get; set; }
        public int ProductsID { get; set; }
        public Products Products { get; set; }
    }
}
