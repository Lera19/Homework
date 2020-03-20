using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate.dll
{
    public class Chocolates

    {
        public double Number;
        public string Firm;
        public double Price;
        public string KindOfChocolate;
        public string Name;
        public string Addition;
    }
    public class ChocolatOptional
    {

        public static List<Chocolates> chocolate = new List<Chocolates>();
        public static void Bacome()
        {
            Chocolates chocolates = new Chocolates();
            Console.Write("Number: ");
            chocolates.Number = ChocolatOptional.Validation();
            Console.Write("Firm: ");
            chocolates.Firm = Console.ReadLine();
            Console.Write("Price: ");
            chocolates.Price = ChocolatOptional.Validation();
            Console.Write("Kind of chocolate: ");
            chocolates.KindOfChocolate = Console.ReadLine();
            Console.Write("Name: ");
            chocolates.Name = Console.ReadLine();
            Console.Write("Addition: ");
            chocolates.Addition = Console.ReadLine();
            ChocolatOptional.chocolate.Add(chocolates);
        }
        public static void Menu()
        {
            int i;

            {
                Console.Write("Menu:\n1)Become \n2)Console  \n3)Console with all information about one chocolate \n4)Delete \n\nYour solution: ");
                i = Validation();
                switch (i)
                {
                    case 1:
                        Bacome();
                        break;
                    case 2:
                        AllInformation();
                        break;
                    case 3:

                        OneInformation();

                        break;
                    case 4:
                        DeleteInformation();
                        break;

                    default:
                        Console.WriteLine("Not correct number, input new...");
                        break;
                }


            }


        }


        public static void OneInformation()
        {


            Console.Write("Input number: ");
            string numbChocolate = Console.ReadLine();
            int numb;
            int.TryParse(numbChocolate, out numb);
            var chocolat = chocolate.FirstOrDefault(c => c.Number == numb);

            if ()
            {
                Console.WriteLine("Don't have information about this chocolate. It's not");
            }
            else
            {
                Console.Write($"Number {chocolat.Number}, Firm {chocolat.Firm}, Price {chocolat.Price}, Kind of chocolate {chocolat.KindOfChocolate}, Name {chocolat.Name}, Addition{chocolat.Addition}");
            }
        }

        public static void DeleteInformation()
        {
            chocolate.Clear();
            Console.WriteLine("All information about chocolate is delete");
        }

        public static int Validation()
        {

            string vString = Console.ReadLine();
            int valString;
            if (int.TryParse(vString, out valString))
            {
                return valString;
            }
            else
            {
                Console.WriteLine("Not correct value, please input number again: ");
                valString = Validation();
            }

            return valString;


        }
        public static string ValidationString()
        {

            string vString = Console.ReadLine();
            //int valString;
            //int.TryParse(vString, out valString);
            if ()
            {
                return vString;
            }
            else
            {
                Console.WriteLine("Not correct value, please input number again: ");
                vString = ValidationString();
            }

            return vString;


        }



        public static void AllInformation()
        {
            for (int i = 0; i < chocolate.Count; i++)
            {
                Console.Write($"Number {chocolate[i].Number}, Firm {chocolate[i].Firm}, Price {chocolate[i].Price}, Kind of chocolate {chocolate[i].KindOfChocolate}, Name {chocolate[i].Name}, Addition{chocolate[i].Addition}\n");

                if (chocolate[i] == null)
                {
                    Console.WriteLine("Chocolate is null");
                }
            }
        }
    }

}
