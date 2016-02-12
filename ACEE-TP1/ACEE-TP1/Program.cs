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

        }
    }
}
