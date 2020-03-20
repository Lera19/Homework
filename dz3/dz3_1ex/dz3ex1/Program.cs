using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dz3_1ex.dll;
using System.Globalization;


namespace dz3_1ex
{
    class Program
    {
        static Double fNumber, lNumber, i;
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");


            Console.Write("First number: ");
            double fNumber = DZ.SetValue();
            Console.Write("Last number: ");
            double lNumber = DZ.SetValue();

            DZ.GetValue(fNumber, lNumber);

            Console.ReadLine();


        }
    }
}
