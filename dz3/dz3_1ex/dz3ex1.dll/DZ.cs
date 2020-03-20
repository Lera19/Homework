using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;



namespace dz3_1ex.dll
{

    public class DZ
    {

        public static void GetValue(double fNumber, double lNumber) // output fizz,buzz, fizzbuzz
        {
            double i;
            for (i = fNumber; i <= lNumber; i++)
            {
                {

                    if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");

                    }


                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine("Simple numbers from the diapason ({0}, {1})", fNumber, lNumber);// simple numbers

            {
                if (i % 1 == 0 && i % i == 0)
                {
                    Console.Write("True");
                }
                else
                {
                    Console.Write("False");
                }
            }

            Console.ReadLine();


        }

        public static double SetValue()//validation
        {

            string vString = Console.ReadLine();
            double valString;
            if (double.TryParse(vString, out valString))
            {
                return valString;
            }
            else
            {
                Console.WriteLine("Not correct value, please input number again: ");
                valString = SetValue();
            }

            return valString;


        }

    }
}
