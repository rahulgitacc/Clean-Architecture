using SGC.ApplicationCore.Entity;

namespace SGC.ApplicationCore.Interfaces.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetClientByProfession(int clientId);
    }
}
