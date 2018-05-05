namespace Bank.Domain.Entities
{
    public class Adres
    {
        public int AdresID { get; set; }
        public int AplikantID { get; set; }
        public string Miasto { get; set; }
        public int KodPocztowy { get; set; }
        public string NumerDomu { get; set; }
        public virtual Aplikant Aplikant { get; set; }
    }
}