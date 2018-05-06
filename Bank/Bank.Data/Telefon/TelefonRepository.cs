using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities;

namespace Bank.Data.Telefon
{
    public class TelefonRepository
    {
        [Key]
        public int TelefonID { get; set; }

        [ForeignKey("Klient")]
        public int KlientID { get; set; }


        public int NumerTelefonu { get; set; }


        public virtual Klient Klient { get; set; }
    }
}
