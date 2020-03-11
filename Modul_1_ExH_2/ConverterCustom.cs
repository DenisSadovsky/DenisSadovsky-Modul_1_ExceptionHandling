using System;

namespace Modul_1_ExH_2
{
    public static class ConverterCustom
    {
        public static void ConvertStrToInt(string str)
        {
            try
            {
                int number = Convert.ToInt32(str.Substring(0, 1));
                Console.WriteLine($"First character number - {number}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
            }
        }
    }
}
