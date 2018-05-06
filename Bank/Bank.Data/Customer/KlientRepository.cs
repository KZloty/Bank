using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities;
using Bank.Entities.KlientViewModel;
using Bank.Data.Telefon;
using Bank.Data.Adres;


namespace Bank.Data.Customer
{
    class KlientRepository
    {
        public KlientCreateViewModel CreateKlient()
        {
            var telefonRepository = new TelefonRepository();
            var adresRepository = new AdresRepository();
            var klient = new KlientCreateViewModel()
            {
                KlientID = 
            }
            return klient;
        }
    }
}
