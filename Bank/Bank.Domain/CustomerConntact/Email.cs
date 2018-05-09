namespace Bank.Domain
{
    public class Email
    {
        public int EmailID { get; set; }

        public string EmailAddress { get; set; }




        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
    }
}