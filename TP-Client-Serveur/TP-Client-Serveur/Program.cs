using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Client_Serveur
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the server (which print the messages) 
            Server.ServerMessages server = new Server.ServerMessages();

            // Create the clients and attach the client to it
            Client.ClientMessages c1 = new Client.ClientMessages(1, server);
            Client.ClientMessages c2 = new Client.ClientMessages(2, server);
            Client.ClientMessages c3 = new Client.ClientMessages(3, server);

            // Then trigger the clients jobs
            c1.triggerJob();
            c2.triggerJob();
            c3.triggerJob();

            Console.ReadLine();
        }
    }
}
