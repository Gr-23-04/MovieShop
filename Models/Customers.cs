namespace DemoGit.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string BillingAddress { get; set; }
        public int BillingZip { get; set; }
        public string BillingCity { get; set; }
        public string DeliveryAddress { get; set; }
        public int DeliveryZip { get; set; }
        public string DeliveryCity { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNo { get; set; }
    }
}
