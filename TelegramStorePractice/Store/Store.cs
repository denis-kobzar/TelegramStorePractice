using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramStorePractice.Model;

namespace TelegramStorePractice.Store
{
    internal sealed class Store<Model>
    {
        private List<StoreClient> _storeClients = new List<StoreClient>();

        public void Subscribe(StoreClient client)
        {
            _storeClients.Add(client);
        }

        private void Notify(StoreClient client)
        {
            foreach (var client in _storeClients)
            {
                client.Update(client);
            }
        }

        public void Add(Model model)
        {
            Notify(model);
        }
    }
}
