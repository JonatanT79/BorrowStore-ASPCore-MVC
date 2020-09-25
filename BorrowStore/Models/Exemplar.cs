namespace BorrowStore.Models
{
    public class Exemplar
    {
        public string ExemplarID { get; set; } //PK
        public int ProductID { get; set; } //FK
        public bool Available { get; set; }
    }
}
//Datum för inlämmning currunt date + 30 days