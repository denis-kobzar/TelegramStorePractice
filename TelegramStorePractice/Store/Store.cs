using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramStorePractice.Client;
using TelegramStorePractice.Model;

namespace TelegramStorePractice.Store
{
    internal sealed class Store
    {
        private List<StoreClient> _storeClients = new List<StoreClient>();

        public void Subscribe(StoreClient client)
        {
            _storeClients.Add(client);
        }

        private void Notify(ModelBase model)
        {
            foreach (var client in _storeClients)
            {
                client.Update(model);
            }
        }

        public void Add(ModelBase model)
        {
            Notify(model);
        }
    }
}
