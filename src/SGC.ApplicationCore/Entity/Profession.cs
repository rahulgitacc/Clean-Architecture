using System.Collections.Generic;

namespace SGC.ApplicationCore.Entity
{
    public class Profession
    {
        public Profession()
        {

        }

        public int ProfessionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CBO { get; set; }
        public ICollection<CustomerService> CustomerServices { get; set; }
    }
}
