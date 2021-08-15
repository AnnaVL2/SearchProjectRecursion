using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalSpace
{
    static class Menu
    {
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Enter File name to search.");
            Console.WriteLine("2. Enter File name to search + parent directory to search in.");
            Console.WriteLine("3. Exit");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();
        }
        public static void DisplayError()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Incorrect Choice!");
            Console.ResetColor();
        }
    }
}
