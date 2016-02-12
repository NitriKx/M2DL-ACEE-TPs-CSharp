using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACEE_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary.Class1.MonWriteLine("Knok Knok Neo, you're in the matrix");
            Console.ReadLine();

            var o = new object();

            // Type anonyme
            var x = new { Nom = "Connor", Prenom = "John" };

            MyLibrary.Class1 c = new MyLibrary.Class1();

            // Setter privé donc marche pas 
            // c.Test = "ok";

            Console.WriteLine("assert " + c.Test + " == KO");
            c.Execute();
            Console.WriteLine("assert " + c.Test + " == coucou");
        }
    }
}
