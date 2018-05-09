using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class Phone
    {
        public int PhoneID { get; set; }

        public string PhoneNumber { get; set; }



        public int PersonID { get; set; }

        public Person Person { get; set; }
    }
}
