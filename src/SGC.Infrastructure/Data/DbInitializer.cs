using SGC.ApplicationCore.Entity;
using System.Linq;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClientContext context)
        {
            if (context.Clients.Any())
            {
                return;
            }

            var clientes = new Client[]
            {
                new Client {
                    Name = "Rahul Sen",
                    CPF = "76664173735"
                },

                 new Client {
                    Name = "James Kamrune",
                    CPF = "54589486377"
                }
            };

            context.AddRange(clientes);

            var contatos = new Contact[]
            {
                new Contact {
                    Name = "Contact 1",
                    Telephone = "99999999",
                    Email = "emailcontato1@teste.com",
                    Client = clientes[0]
                },

                new Contact {
                    Name = "Contact 2",
                    Telephone = "333333",
                    Email = "emailcontato2@teste.com",
                    Client = clientes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();

        }
    }
}
