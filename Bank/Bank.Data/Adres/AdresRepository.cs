using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities;

namespace Bank.Data.Adres
{
    public class AdresRepository
    {
        [Key]
        public int AdresID { get; set; }

        [ForeignKey("Klient")]
        public int KlientID { get; set; }

        [Required]
        [MaxLength(20), MinLength(2)]
        public string Miasto { get; set; }

        [Range(00000,99999)]
        public int KodPocztowy { get; set; }

        [Required]
        [MaxLength(20), MinLength(2)]
        public string Ulica { get; set; }

        [Required]
        public string NumerDomu { get; set; }
        
        [Required]
        public virtual Klient Klient { get; set; }
    }
}
