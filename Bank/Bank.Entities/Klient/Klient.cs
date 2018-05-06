using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Entities
{
    public class Klient
    {
        [Key]
        [Range(1000000, 9999999)]
        public int KlientID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int PESEL { get; set; }
        public virtual List<Telefon> NumeryTelefonow { get; set; }
        public List<Adres> Adresy { get; set; }
    }
}
