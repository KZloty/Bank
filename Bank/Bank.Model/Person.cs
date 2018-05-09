using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class Person
    {
        public int PersonID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public int PESEL { get; set; }




        //public virtual List<Address> Addresses { get; set; }

        public virtual List<Phone> Phones { get; set; }

        //public virtual List<Email> Emails { get; set; }

    }
}
