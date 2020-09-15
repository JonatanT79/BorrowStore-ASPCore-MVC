using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Required]
        public DateTime BorrowDate { get; set; }
        [Required]
        public string Product { get; set; }
        public DateTime? HandedIn { get; set; }
        public bool Late { get; set; }
        public int DaysLate { get; set; }
        [Required]
        public string UserID { get; set; }
    }
}
