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

        public delegate void WriteMessage(int clientId, int messageId);

        private WriteMessage messageWriterLambda;

        public ClientMessages(int clientId, WriteMessage messageWriterLambda)
        {
            this.clientId = clientId;
            this.messageWriterLambda = messageWriterLambda;
        }

        public void triggerJob()
        {
            // Send messages to the server. Each message is prefixed with the client identifier.
            for (int i = 0; i < 3; i++)
            {
                messageWriterLambda(clientId, i);
            }
        }
    }
}
