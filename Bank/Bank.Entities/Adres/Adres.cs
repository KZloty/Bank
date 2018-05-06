using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank.Domain.Entities
{
    public class Adres
    {
        [Key]
        public int AdresID { get; set; }
        [ForeignKey("Klient")]
        public int KlientID { get; set; }
        public string Miasto { get; set; }
        public int KodPocztowy { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public virtual Klient Klient { get; set; }
    }
}