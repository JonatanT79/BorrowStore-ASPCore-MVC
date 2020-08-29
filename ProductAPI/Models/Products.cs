using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CopyCount { get; set; }
    }
}
