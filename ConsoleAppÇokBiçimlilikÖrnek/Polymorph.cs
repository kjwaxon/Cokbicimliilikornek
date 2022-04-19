using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppÇokBiçimlilikÖrnek
{
    class Polymorph : Örnek
    {
        public override void example()
        {
            Console.Title = "Example";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Type of this example : Polymorph");
        }
    }
}
