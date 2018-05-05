namespace Bank.Domain.Entities
{
    public class NumerTelefonu
    {
        public int NumerTelefonuID { get; set; }
        public int Numer { get; set; }
        public int AplikantID { get; set; }
        public virtual Aplikant Aplikant { get; set; } 
    }
}