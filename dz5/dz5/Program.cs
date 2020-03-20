using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dz5.dll;

namespace dz5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input n= ");
            Optional.Matrix();
            Console.WriteLine("Transpose: ");
            Optional.Transpose();
            Console.WriteLine("Triangular Matrix Top: ");
            Optional.TriangularMatrixTop();
            Console.WriteLine("Triangular Matrix Bottom: ");
            Optional.TriangularMatrixBottom();
            Optional.Menu();
            Optional.Menu();

            Console.ReadLine();
        }
    }
}
