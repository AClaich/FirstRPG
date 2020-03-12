using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJeuTP
{
    class Ghost : MonstreFacile
    {
        public void Display()
        {
            Console.WriteLine("     .-.");
            Console.WriteLine("   .'   `.");
            Console.WriteLine("   :g g   :");
            Console.WriteLine("   : o    `.");
            Console.WriteLine("  :         ``.");
            Console.WriteLine(" :             `.");
            Console.WriteLine(":  :         .   `.");
            Console.WriteLine(":   :          ` . `.");
            Console.WriteLine(" `.. :            `. ``;");
            Console.WriteLine("    `:;             `:'");
            Console.WriteLine("       :              `.");
            Console.WriteLine("        `.              `.     .");
            Console.WriteLine("          `'`'`'`---..,___`;.-'");
        }
    }
}
