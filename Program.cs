using System;

namespace BinaryToDecimal
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you enter the decimal number you want to translate into binary code?");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());

            string ConvertedToBinary = "";


            while (decimalNumber > 0)        //when it is equal to 0, the division process ends.
            {
                if (decimalNumber % 2 == 0)
                {
                    ConvertedToBinary += 0;   
                }
                else if (decimalNumber % 2 == 1)
                {
                    ConvertedToBinary += 1;
                }


                decimalNumber /= 2;      //the new value entered is the result of half of the value I entered.

            }

            char[] array = ConvertedToBinary.ToCharArray();
            Array.Reverse(array);           //I printed it backward, I used the reverse function to turn it into a flat one here.
            Console.WriteLine(array);
        }
    }
}
