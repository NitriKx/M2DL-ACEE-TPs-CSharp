using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Class1
    {
        // FAÇON 1 - Déclaration explicite des attributs
        private string test = "KO";

        // FAÇON 2 - Utilisation des accesseurs
        public string Test
        {
            get
            {
                return test;
            }
            // Ne pourra pas être appelé de l'extérieur (override le "public" au dessus) 
            private set
            {
                test = value;
            }
        }

        // FAÇON 3 - Inférence d'attributs
        public string Infered { get; private set; }




        public void Execute()
        {
            Test = "coucou";
        }

        public static void MonWriteLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);

        }
    }
}
