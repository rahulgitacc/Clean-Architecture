using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC.ApplicationCore.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Add(Client entity)
        {
            return _clientRepository.Add(entity);
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetTodos()
        {
            throw new NotImplementedException();
        }

        public void Remove(Client entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> Search(Expression<Func<Client, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
