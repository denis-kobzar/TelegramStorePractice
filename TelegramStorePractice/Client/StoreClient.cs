using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramStorePractice.Model;

namespace TelegramStorePractice.Client
{
    internal abstract class StoreClient
    {
        public abstract void Update(ModelBase model);
    }
}
