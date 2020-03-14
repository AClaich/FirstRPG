using System;
using System.Collections.Generic;
using System.Text;

namespace MiniJeuTP
{
    class Dragon : MonstreDifficile
    {
        public void Display()
        {
            Console.WriteLine("    \\||//                ");
            Console.WriteLine("oo___@  |                ");
            Console.WriteLine("|,,,,__) \\   /\\  /\\     ");
            Console.WriteLine("       (_ \\/^ (/^\\ (     ");
            Console.WriteLine("       (_   \\/^\\   (     ");
            Console.WriteLine("       (_ \\  \\ _   (     ");
            Console.WriteLine("      (_( |  || \\/\\(  /\\ ");
            Console.WriteLine("     (__( (,,)|      <  >");
            Console.WriteLine("    /(___(/    \\      || ");
            Console.WriteLine("___( (___(      )____/ | ");
            Console.WriteLine(";;;__ ;;;_______)______/  ");
        }
    }
}
