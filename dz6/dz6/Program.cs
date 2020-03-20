using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using menu.dll;

namespace dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Menu:\n1)Become rectangle \n2)Console 1 figure  \n3)Console all figure \n4)Add in mas \n\nYour solution: ");
                Menu menu = new Menu();
                menu.Menu1();
                Console.Write("If you want close program input break");
                {
                    string i = Console.ReadLine();
                    if (i == "break")
                        break;
                }
                Console.ReadLine();

            }
        }
    }
}
