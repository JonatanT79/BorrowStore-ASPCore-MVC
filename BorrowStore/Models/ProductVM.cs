using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowStore.Models
{
    public class ProductVM
    {
        public List<Product> productList { get; set; }
        public int productCount { get; set; }
    }
}
