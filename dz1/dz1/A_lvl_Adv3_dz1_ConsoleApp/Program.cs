using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_lvl_Adv3_dz1_Dll;

namespace A_lvl_Adv3_dz1_ConsoleApp
{
    class Program
    {
        static Double a, b, c;
        static void Main(string[] args)
        {
            {

                while(true)
                {


                    Console.Write("Value input a: ");
                    double a = CustomMath.SetValue();
                    Console.Write("Value input b: ");
                    double b = CustomMath.SetValue();
                    Console.Write("Value input c: ");
                    double c = CustomMath.SetValue();
                    
                    Console.WriteLine($"FORMULA: {a}x^2+({b})x+({c}) = 0 ");

                    CustomMath.Discrim(a,b,c);
 
                    Console.WriteLine("\nIf you want close this program input break: ");

                    {
                        string breakString = Console.ReadLine();
                        if (breakString == "break")
                        {
                            break;
                        }
                    }

                }
            }



        }
    }


}
