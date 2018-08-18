namespace SGC.ApplicationCore.Entity
{
    public class Contact
    {
        public Contact()
        {

        }

        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
