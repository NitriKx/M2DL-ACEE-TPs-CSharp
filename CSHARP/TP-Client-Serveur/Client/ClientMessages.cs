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
        public int ClientId { get; }

        private event EventHandler<MessageEventArgs> SendMessageDone;

        public ClientMessages(int clientId, EventHandler<MessageEventArgs> SendMessageDone)
        {
            this.ClientId = clientId;
            this.SendMessageDone = SendMessageDone;
        }

        public void triggerJob()
        {
            // Try to throw an exception
            if (ClientId == 25)
            {
                throw new ArgumentException(nameof(ClientId) + " " + ClientId + " unauthorized to send messages");
            }
            
            // Send message to the server
            if (this.SendMessageDone != null)
            {
                SendMessageDone(this, new MessageEventArgs() { Message = $"Client {ClientId} has sent message" });
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
