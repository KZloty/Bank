using Bank.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bank.WebUI.Models
{
    public class KlientViewModel
    {
        [Key]
        //[Range(1000000, 9999999)]
        public int KlientID { get; set; }

        [Required]
        //[MaxLength(20), MinLength(2)]
        public string Imie { get; set; }

        //[Required]
        //[MaxLength(20), MinLength(2)]
        public string Nazwisko { get; set; }

        public int PESEL { get; set; }

        public Adres Adres { get; set; }

        public Telefon Telefon { get; set; }
        
    }
}