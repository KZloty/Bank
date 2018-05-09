using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank.Entities
{
    public class Adres
    {
        [Key]
        public int AdresID { get; set; }

        [ForeignKey("Klient")]
        public int KlientID { get; set; }

        [Required]
        [MaxLength(20), MinLength(2)]
        public string Miasto { get; set; }

        //[Range(00000,99999)]
        public int? KodPocztowy { get; set; }

        //[Required]
        //[MaxLength(20), MinLength(2)]
        public string Ulica { get; set; }

        //[Required]
        public string NumerDomu { get; set; }
        
        [Required]
        public virtual Klient Klient { get; set; }
    }
}