using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.ConsoleUI
{
    public class UI
    {

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static void Write(string message)
        {
            Console.Write(message);
        }
        public static string GetInput()
        {
            return Console.ReadLine() ?? string.Empty;
        }
        public static void Clear()
        {
            Console.Clear();
        }
    }
}
