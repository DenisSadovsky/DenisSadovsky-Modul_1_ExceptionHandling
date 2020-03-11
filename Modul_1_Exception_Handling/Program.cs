using System;
using Modul_1_ExH_2;

namespace Modul_1_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nEnter a string to analyze");
                string StrIn = Console.ReadLine();
                try
                {
                    CheckFirstSymbol(StrIn);            
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"An exception has occurred, {e.Message}");
                    throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
                }

                Console.WriteLine("\nCheck the first character for a number\n");
                ConverterCustom.ConvertStrToInt(StrIn);


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public static void CheckFirstSymbol(string str)
        {
            if (str.Substring(0, 1) != "")
            {
                Console.WriteLine($"{str.Substring(0, 1)}");
            }

        }
    }
}
