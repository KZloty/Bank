namespace Bank.Domain
{
    public class Phone
    {
        public int PhoneID { get; set; }

        public string PhoneNumber { get; set; }



        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
    }
}