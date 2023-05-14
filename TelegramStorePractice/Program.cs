using TelegramStorePractice.Client;
using TelegramStorePractice.FactoryMethod;
using TelegramStorePractice.Model;
using static TelegramStorePractice.Store.Store;

namespace TelegramStorePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new TelegramClient();
            Store.Store store = Store.Store.GetInstance();

            while(true)
            {
                Console.WriteLine("Id");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Name");
                string name = Console.ReadLine();

                Console.WriteLine("Link");
                string link = Console.ReadLine();

                Console.WriteLine("Description");
                string descr = Console.ReadLine();

                store.Add(UserFactory.Create(id, link, name, descr));
            }
        }
    }
}