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
            // Create the clients and attach the client to it
            Client.ClientMessages c1 = new Client.ClientMessages(1, OnSendMessageDone);
            Client.ClientMessages c2 = new Client.ClientMessages(2, OnSendMessageDone);
            Client.ClientMessages c3 = new Client.ClientMessages(3, OnSendMessageDone);

            // Then trigger the clients jobs
            c1.triggerJob();
            c2.triggerJob();
            c3.triggerJob();

            Console.ReadLine();
        }

        public static void OnSendMessageDone(object sender, Client.MessageEventArgs eventArgs)
        {
            server.receiveMessage(eventArgs.Message);
        }
    }
}
