using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramStorePractice.Model;

namespace TelegramStorePractice.Client
{
    internal class TelegramClient : IStoreClient
    {
        public TelegramClient() 
        {
            Store.Store store = Store.Store.GetInstance();
            store.Subscribe(this);
        }
        public void Update(ModelBase model)
        {
            Console.WriteLine(model.ToString());
        }
    }
}
