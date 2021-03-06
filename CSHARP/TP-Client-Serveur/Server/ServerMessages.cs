﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerMessages
    {
        private List<string> messageHistory = new List<string>();

        public ServerMessages() { }



        public void receiveMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            messageHistory.Add("[SERVER] " + DateTime.Now + " " + message);
        }

        public void receiveMessage(string message)
        {
            receiveMessage(message, ConsoleColor.White);
        }

        public void printHistory()
        {
            Console.WriteLine("[SERVER] " + DateTime.Now + " Printing sever history with " + messageHistory.Count() + " messages");
            foreach(var m in messageHistory)
            {
                Console.WriteLine(m);
            }
        }
    }
}
