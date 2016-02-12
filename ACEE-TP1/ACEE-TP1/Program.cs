using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACEE_TP1
{
    class Program
    {

        private static String Test = null;

        public static void ExecuteBonjour()
        {
            Test = "bonjour";
        }

        public static void ExecuteAuRevoir()
        {
            Test = "aurevoir";
        }

        public delegate void Methode();

        public static Methode ProchaineExecution = ExecuteBonjour; 

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

            // Indirection de méthodes
            ProchaineExecution.Invoke();
            ProchaineExecution = ExecuteAuRevoir;
            Console.WriteLine("assert " + Test + " == bonjour");

            ProchaineExecution.Invoke();
            Console.WriteLine("assert " + Test + " == aurevoir");
        }
    }
}
