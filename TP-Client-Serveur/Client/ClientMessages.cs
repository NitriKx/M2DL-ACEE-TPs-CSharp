using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientMessages
    {
        private int clientId;
        private Server.ServerMessages serverClientIsAttachedTo;

        public ClientMessages(int clientId, Server.ServerMessages serverClientIsAttachedTo)
        {
            this.clientId = clientId;
            this.serverClientIsAttachedTo = serverClientIsAttachedTo;
        }

        public void triggerJob()
        {
            // Send messages to the server. Each message is prefixed with the client identifier.
            for (int i = 0; i < 3; i++)
            {
                this.serverClientIsAttachedTo.receiveMessage("Client " + clientId + " has sent message n°" + i);
            }
        }
    }
}
