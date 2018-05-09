using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class Email
    {
        public int EmailID { get; set; }

        public string EmailAddress { get; set; }




        public int PersonID { get; set; }

        public Person Person { get; set; }
    }
}
