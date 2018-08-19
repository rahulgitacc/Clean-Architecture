using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC.ApplicationCore.Interfaces.Services
{
    public interface IClientService
    {
        Client Add(Client entity);
        void Update(Client entity);
        IEnumerable<Client> GetTodos();
        Client GetById(int id);
        IEnumerable<Client> Search(Expression<Func<Client, bool>> Predicate);
        void Remove(Client entity);
    }
}
