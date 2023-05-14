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
        private List<IStoreClient> _storeClients = new List<IStoreClient>();
        private static Store store;

        public static Store GetInstance()
        {
            if (store == null)
            {
                store = new Store();
            }
            return store;
        }

        private Store() { }

        public void Subscribe(IStoreClient client)
        {
            store._storeClients.Add(client);
        }

        private void Notify(ModelBase model)
        {
            foreach (var client in store._storeClients)
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
