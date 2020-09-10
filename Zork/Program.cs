using System;
using System.Runtime.CompilerServices;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine();
            Commands command = ToCommand(inputString.Trim().ToUpper());
            Console.WriteLine(command);

        }

        private static Commands ToCommand(string inputString) => Enum.TryParse(inputString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}
