using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Entities
{
    public class Aplikant
    {
        public int AplikantID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int PESEL { get; set; }
        public virtual List<NumerTelefonu> NumeryTelefonu { get; set; }
        public virtual List<Adres> Adresy { get; set; }
    }
}
