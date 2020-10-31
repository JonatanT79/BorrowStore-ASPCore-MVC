using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Product { get; set; }
        public bool IsActive { get; set; }
        public DateTime? HandedIn { get; set; }
        public DateTime? DateToHandIn { get; set; }
        public bool Late { get; set; }
        public int DaysLate { get; set; }
        public string UserID { get; set; }
    }
}
