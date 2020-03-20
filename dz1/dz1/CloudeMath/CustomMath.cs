using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_lvl_Adv3_dz1_Dll
{
    public class CustomMath
    {
        static double root1, root2 , discrim;
        public static void Discrim(double a, double b, double c)
        {
            discrim = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Discriminant = " + discrim);

            if (a == 0)
            {
                Console.WriteLine("Error-division by zero is not correct, a=0");

            }
            else
            {
               
                if (discrim < 0)
                {
                    Console.WriteLine("Discriminant < 0 don't have roots");
                    Console.WriteLine($"Roots: Not roots");
                }
                else if (discrim > 0)
                {
                    Console.WriteLine("Discriminant > 0 has two roots");
                    Console.WriteLine($"Roots: Root1 =" + Root1(a, b) + ",Root2 = " + Root2(a, b));
                }
                else
                {
                    Console.WriteLine("Discriminant = 0 has one roots");
                    Console.WriteLine($"Roots: Root1 =" + Root1(a, b));
                }
                Factorization(a,b,c);

            }
        }


        public static double Root1(double a, double b)
        {

            return (-b + Math.Sqrt(discrim)) / (2 * a);

        }
            public static double Root2(double a, double b)
        {


            return (-b - Math.Sqrt(discrim)) / (2 * a);

        }

        public static double SetValue() 
        {
           
                string vString = Console.ReadLine();
                double valString;
                if (Double.TryParse(vString, out valString))
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

        public static void Factorization(double a, double b, double c) //linear factors
        {
            if (discrim >= 0)
            {
             Console.Write($"LM: ({a})x^2+({b})x+({c})={a}*(x - ({Root1(a,b)}))*(x - ({Root2(a,b)}))");
            }
            else
            {
                Console.Write($"LM: D<0 not solution");
            }
            return;

        }

      

    }

}

