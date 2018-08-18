namespace SGC.ApplicationCore.Entity
{
    public class CustomerService
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
    }
}
