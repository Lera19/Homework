using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6.dll
{
    public struct Rectangle : IShape
    {
        public int Id;
        public double Height;
        public double Width;
        public double PointX;
        public double PointY;

        public static List<Rectangle> rectangles = new List<Rectangle>();
        public void Bacome()
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("Id: ");
            rectangle.Id = Validation();
            Console.Write("Height: ");
            rectangle.Height = Validation();
            Console.Write("Width: ");
            rectangle.Width = Validation();
            Console.Write("PointX: ");
            rectangle.PointX = Validation();
            Console.Write("PointY: ");
            rectangle.PointY = Validation();
            rectangles.Add(rectangle);
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

        public override string ToString()
        {
            return $"Id {Id}, Height {Height}, Width {Width}, PointX {PointX}, PointY {PointY}";
        }

        public void Print()
        {
            foreach (var i in rectangles)
            {
                Console.WriteLine(i);
            }
        }
        public void AddFigure()
        {
            Rectangle[] rectanmas = new Rectangle[100];
            rectanmas = rectangles.ToArray();
            foreach (var i in rectanmas)
            {
                Console.WriteLine("mas is ");
                Console.WriteLine(i);
            }
        }

        public static void OneInformation()
        {
            int index = Validation();
            Console.Write($"Number {rectangles[index].Id}, Height {rectangles[index].Height}, Width {rectangles[index].Width}, " +
                $"PointX {rectangles[index].PointX}, PointY {rectangles[index].PointY}\n");
        }

    }
}


