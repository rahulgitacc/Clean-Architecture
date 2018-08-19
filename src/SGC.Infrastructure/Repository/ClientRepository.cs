using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.Infrastructure.Data;
using System.Linq;

namespace SGC.Infrastructure.Repository
{
    public class ClientRepository : EFRepository<Client>, IClientRepository
    {
        public ClientRepository(ClientContext dbContext) : base(dbContext)
        {

        }

        public Client GetClientByProfession(int clientId)
        {
            return Search(x => x.CustomerServices.Any(p => p.ClientId == clientId)).FirstOrDefault();
        }
    }
}
