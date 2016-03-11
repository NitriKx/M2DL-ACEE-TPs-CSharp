using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Client
    {
        public event EventHandler<MessageEventArgs> SendMessageDone;
        public string Nom { get; set; }

        public void SendMessage(string message)
        {
            if (Nom == "Client #23")
            {
                throw new ArgumentException("Message incorrect", nameof(message));
            }

            if (SendMessageDone != null)
            {
                SendMessageDone(this, new MessageEventArgs { Message = message });
            }
        }
    }

    public class MessageEventArgs: EventArgs
    {
        public string Message { get; set; }
    }


}
