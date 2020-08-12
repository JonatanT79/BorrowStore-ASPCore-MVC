using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowStore.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Exemplar
    {
        public string ExemplarID { get; set; } //PK
        public int ProductID { get; set; } //FK
        public bool Available { get; set; }
    }
}
//Datum för inlämmning currunt date + 30 days