using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    /*


    */
    public class ClientMessages
    {
        private int clientId;

        private event EventHandler<MessageEventArgs> SendMessageDone;

        public ClientMessages(int clientId, EventHandler<MessageEventArgs> SendMessageDone)
        {
            this.clientId = clientId;
            this.SendMessageDone = SendMessageDone;
        }

        public void triggerJob()
        {
            // Send messages to the server. Each message is prefixed with the client identifier.
            for (int i = 0; i < 3; i++)
            {
                if (this.SendMessageDone != null)
                {
                    SendMessageDone(this, new MessageEventArgs() { Message = "Client " + clientId + " has sent message " + i });
                }
            }
        }
    }

    /*

    */
    public class MessageEventArgs: EventArgs
    {
        public string Message { get; set; }
    }
}
