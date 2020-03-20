using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Chocolate.dll;

namespace dz4
{

    class Program
    {
        //static List<Chocolates> chocolates = new List<Chocolates>();
        //static List <Chocolates> chocolate;

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            while (true)
            {
                ChocolatOptional.Bacome();
                Console.Write("If you want break, input break");
                {
                    string close = Console.ReadLine();
                    if (close == "break")
                    {
                        break;
                    }
                }

                ChocolatOptional.Menu();
                Console.ReadLine();

            }
        }
    }
}
