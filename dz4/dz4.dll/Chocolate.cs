using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.dll
{

    public class Chocolate
    {
        public double Number;
        public string Firm;
        public double Price;
        public string KindOfChocolate;
        public string Name;
        public string Addition;
       

       // public static List<Chocolate> chocolates = new List<Chocolate>();

      //  public static Chocolate chocolate = new Chocolate();


        public static void Menu(List<Chocolate> chocolates)
        {
            int i;

            {
                Console.Write("Menu:\n1)Become \n2)Console  \n3)Console with all information about one chocolate \n4)Delete \n\nYour solution: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:

                        break;
                    case 2:
                        AllInformation(chocolates);
                        break;
                    case 3:

                        OneInformation(chocolates);
                        
                        break;
                    case 4:
                        DeleteInformation(chocolates);
                        break;

                    default:
                        Console.WriteLine("Not correct number, input new...");
                        break;
                }

                Console.Clear();
            }


        }


        public static void OneInformation(List<Chocolate> chocolates)
        {
            
            
                Console.WriteLine("Input number: ");
                string numbChocolate = Console.ReadLine();
                int numb;
                int.TryParse(numbChocolate, out numb);
                var chocolate = chocolates.FirstOrDefault(c => c.Number == numb);
                Console.WriteLine($"Number {chocolate.Number}, Firm {chocolate.Firm}, Price {chocolate.Price}, Kind of chocolate {chocolate.KindOfChocolate}, Name {chocolate.Name}, Addition{chocolate.Addition}");
                Console.ReadLine();

        }

        public static string DeleteInformation(List<Chocolate> chocolates)
        {
            chocolates.Clear();
            return "All information about chocolate is delete";
        }

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

        public static void AllInformation(List<Chocolate> chocolates)
        {
            for (int i = 0; i < chocolates.Count; i++)
            {
                Console.WriteLine($"{chocolates[i]}");
            }


        }

    }
}
