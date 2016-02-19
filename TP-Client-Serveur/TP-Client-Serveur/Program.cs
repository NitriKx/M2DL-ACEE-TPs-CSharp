using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Client_Serveur
{
    class Program
    {

        private static Server.ServerMessages server = new Server.ServerMessages();

        static void Main(string[] args)
        {
            // Create the clients with a list
            var clientList = new List<Client.ClientMessages>();
            for (int i = 0; i < 50; i++)
            {
                clientList.Add(new Client.ClientMessages(i, OnSendMessageDone));
            }

            var restrictedClientList = clientList.Skip(3).Take(40).OrderBy(client => client.ClientId);

            //var restrictedClientList2 = from x in clientList
            //                            where x.ClientId == 1
            //                            select x.ClientId;

            //var restrictedClientList3 = clientList.

            // Then trigger the clients jobs
            foreach (var client in clientList)
            {
                client.triggerJob();
            }
            Console.ReadLine();

            server.printHistory();
            Console.ReadLine();
        }

        public static void OnSendMessageDone(object sender, Client.MessageEventArgs eventArgs)
        {
            server.receiveMessage(eventArgs.Message);
        }
    }
}
