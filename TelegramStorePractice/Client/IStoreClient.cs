using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramStorePractice.Model;

namespace TelegramStorePractice.Client
{
    internal interface IStoreClient
    {
        public void Update(ModelBase model);
    }
}
