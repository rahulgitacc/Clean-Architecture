namespace SGC.ApplicationCore.Entity
{
    public class Address
    {
        public Address()
        {

        }

        public int AddressId { get; set; }
        public string PublicPlace { get; set; }
        public string Neighborhood { get; set; }
        public string CEP { get; set; }
        public string Reference { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
