namespace Bank.Domain
{
    public class Address
    {
        public int AddressID { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }


        public int CustomerID { get; set; }

        public Customer Customer { get; set; }


    }
}