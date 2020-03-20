using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using GAMER;

namespace dz3_ex2.dll
{
    public class Optional
    {
        static Double SumDistance;
        public static double SetValue()//validation
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

        public static void Addition(double DistanceFirstDay, double Coefficient, double Distance)//SumDistance
        {

            int day = 1;
            SumDistance = DistanceFirstDay;
            while (SumDistance <= Distance)
            {

                SumDistance = SumDistance + (DistanceFirstDay * (Coefficient / 100));

                day += 2;
                Console.WriteLine("{0} on {1} day", SumDistance, day);
                Console.ReadLine();




            }

        }


        public  static void Menu(List<Gamer> gamers)
        {
            int i;

            

                {
                    Console.Write("Menu:\n1)Become \n2)Console \n\nYour solution: ");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                           
                            break;
                        case 2:
                            Output(gamers);
                            break;
                        
                        default:
                            Console.WriteLine("Not correct number, input new...");
                            break;
                    }
                  
                    Console.Clear();
                }

            
        }


        public static void Output(List<Gamer> gamers )
        {
            Console.WriteLine("Input numberGamer: ");
            string numbGamer = Console.ReadLine();
            int numb;
            int.TryParse(numbGamer, out numb);
            var gamer = gamers.FirstOrDefault(g => g.Number == numb);
            Console.WriteLine($"Number gamer {gamer.Number}, DistanceFirstDay {gamer.DistanceFirstDay}, Coefficient {gamer.Coefficient}, Distance {gamer.Distance} ");
            Console.ReadLine();
        }
    }
}



