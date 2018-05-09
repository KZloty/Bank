using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class Address
    {
        public int AddressID { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }


        public int PersonID { get; set; }

        public Person Person { get; set; }


    }
}
