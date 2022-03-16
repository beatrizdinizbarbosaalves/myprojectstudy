using System;
using System.Numerics;

namespace PrimitiveTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplos de tipos primitivos em c#");

            ExampleBool();
            ExampleByte();
            ExampleInt();
            ExampleSingle();
            ExampleChar();
            ExampleSingle();
        }

        private static void ExampleBool()
        {
            bool raining = false;
            bool busLate = true;

            Console.WriteLine($"It is raining: {raining}");
            Console.WriteLine($"The bus is late: {busLate}");
        }
        private static void ExampleByte()
        {
            int int1 = 128;
            try
            {
                byte value1 = (byte)int1;
                Console.WriteLine(value1);
            }
            catch (OverflowException)
            {
                Console.WriteLine($"{int1} is out of range of a byte.");
            }

            double dbl2 = 3.997;
            try
            {
                byte value2 = (byte)dbl2;
                Console.WriteLine(value2);
            }
            catch (OverflowException)
            {
                Console.WriteLine($"{dbl2} is out of range of a byte.");
            }
        }

        private static void ExampleInt()
        {
            long lNumber = 163245617;
            try
            {
                int number1 = (int)lNumber;
                Console.WriteLine(number1);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is out of range of an Int32.", lNumber);
            }

            double dbl2 = 35901.997;
            try
            {
                int number2 = (int)dbl2;
                Console.WriteLine(number2);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is out of range of an Int32.", dbl2);
            }

            BigInteger bigNumber = 132451;
            try
            {
                int number3 = (int)bigNumber;
                Console.WriteLine(number3);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is out of range of an Int32.", bigNumber);
            }
        }

        private static void ExampleChar()
        {
            char chA = 'A';
            char ch1 = '1';
            string str = "test string";

            Console.WriteLine(chA.CompareTo('B'));          //-----------  Output: "-1" (meaning 'A' is 1 less than 'B')
            Console.WriteLine(chA.Equals('A'));             //-----------  Output: "True"
            Console.WriteLine(Char.GetNumericValue(ch1));   //-----------  Output: "1"
            Console.WriteLine(Char.IsControl('\t'));        //-----------  Output: "True"
            Console.WriteLine(Char.IsDigit(ch1));           //-----------  Output: "True"
            Console.WriteLine(Char.IsLetter(','));          //-----------  Output: "False"
            Console.WriteLine(Char.IsLower('u'));           //-----------  Output: "True"
            Console.WriteLine(Char.IsNumber(ch1));          //-----------  Output: "True"
            Console.WriteLine(Char.IsPunctuation('.'));     //-----------  Output: "True"
            Console.WriteLine(Char.IsSeparator(str, 4));    //-----------  Output: "True"
            Console.WriteLine(Char.IsSymbol('+'));          //-----------  Output: "True"
            Console.WriteLine(Char.IsWhiteSpace(str, 4));   //-----------  Output: "True"
            Console.WriteLine(Char.Parse("S"));             //-----------  Output: "S"
            Console.WriteLine(Char.ToLower('M'));           //-----------  Output: "m"
            Console.WriteLine('x'.ToString());              //-----------  Output: "x"

        }
        private static void ExampleSingle()
        {
            Single value = .2f;
            Single result1 = value * 10f;
            Single result2 = 0f;
            for (int ctr = 1; ctr <= 10; ctr++)
                result2 += value;

            Console.WriteLine(".2 * 10:           {0:R}", result1);
            Console.WriteLine(".2 Added 10 times: {0:R}", result2);
        }
    }
}
