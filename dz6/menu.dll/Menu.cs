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

                {
                    i = Rectangle.Validation();
                    switch (i)
                    {
                        case 1:
                            Rectangle rectangle = new Rectangle();
                            rectangle.Bacome();
                            break;
                        case 2:
                            Rectangle.OneInformation();
                            break;
                        case 3:

                            Rectangle rectangle1 = new Rectangle();
                            rectangle1.Print();
                            break;
                        case 4:

                            break;


                        default:
                            Console.WriteLine("Not correct number, input new...");
                            break;
                    }
                }
            }

        }
    }

}
