using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bank.WebUI.Models
{
    public class ApplicationForm
    {
        [Key]
        public int ApplicationID { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public int PESEL { get; set; }

        public string Miasto { get; set; }

        public int KodPocztowy { get; set; }

        public string Ulica { get; set; }

        public string NumerDomu { get; set; }

        public int NumerTelefonu { get; set; }
    }
}