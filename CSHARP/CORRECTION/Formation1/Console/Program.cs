using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        private static Server.Server server;

        static void Main(string[] args)
        {
            try
            {

                server = new Server.Server();
                var listeClients = new List<Client.Client>();

                for (int i = 0; i < 50; i++)
                {
                    var client = new Client.Client {Nom = "Client #" + i};
                    client.SendMessageDone += OnSendMessageDone;
                    listeClients.Add(client);
                }

                var listeReduite = listeClients.Skip(3).Take(40).OrderBy(client => client.Nom);

                foreach (var client in listeReduite)
                {
                    client.SendMessage($"Message de {client.Nom} à {DateTime.Now}");
                }
            }
            catch (ArgumentException exception)
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("ERREUR : " + exception.StackTrace);
            }

        }

        private static void OnSendMessageDone(object sender, Client.MessageEventArgs eventArgs)
        {
            server.WriteMessage(eventArgs.Message);
        }
    }
}
