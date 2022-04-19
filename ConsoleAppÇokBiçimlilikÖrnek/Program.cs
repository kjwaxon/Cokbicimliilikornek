using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppÇokBiçimlilikÖrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Örnek orn = new Örnek();
             orn.example();
             Console.ReadKey();
            */

            Polymorph p = new Polymorph();

            p.example();

            Console.ReadKey();
        }
    }
}
