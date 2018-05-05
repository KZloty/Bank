using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Entities
{
    public class Telefon
    {
        [Key]
        public int TelefonID { get; set; }
        [ForeignKey("Klient")]
        public int KlientID { get; set; }
        public int NumerTelefonu { get; set; }
        public virtual Klient Klient { get; set; }
    }
}
