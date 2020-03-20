using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dz3_ex2.dll;
using System.Globalization;
using GAMER;

namespace dSumDistance3_eDistanceFirstDaCoeficient2
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            List < Gamer > gamers = new List<Gamer>();
            while (true)
            {
                

                Gamer gamer = new Gamer();
                
                Console.Write("GamerNumber= ");
                gamer.Number = Optional.SetValue();
                Console.Write("DistanceFirstDay= ");
                gamer.DistanceFirstDay = Optional.SetValue();
                Console.Write("Coefficient= ");
                gamer.Coefficient = Optional.SetValue();
                Console.Write("Distance= ");
                gamer.Distance = Optional.SetValue();
                gamers.Add(gamer);
                Optional.Addition(gamer.DistanceFirstDay, gamer.Coefficient, gamer.Distance);


                Console.Write("\nIf you want close this program input 0, if you want work this program input anything");

                {
                    string breakString = Console.ReadLine();
                    if (breakString == "0")
                    {
                        break;
                    }
                }
                Optional.Menu(gamers);
            }
        }
    }
}
