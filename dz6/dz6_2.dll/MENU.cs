using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dz6.dll;

namespace menu.dll
{
    public class Menu
    {

        public void Menu1()
        {
            int i;
            Rectangle rectangle = new Rectangle();
            {
                i = Rectangle.Validation();
                switch (i)
                {
                    case 1:
                        rectangle.Bacome();
                        break;
                    case 2:
                        Rectangle.OneInformation();
                        break;
                    case 3:
                        rectangle.Print();
                        break;
                    case 4:
                        rectangle.AddFigure();
                        break;
                    default:
                        Console.WriteLine("Not correct number, input new...");
                        break;
                }
            }
        }

    }
}

