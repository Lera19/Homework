using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5.dll
{
    public class Optional
    {

        static int n = Validation();
        public static int[,] matrix;



        public static void Matrix()
        {

            Random random = new Random();

            matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }


            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                    var matr = matrix[i, j];
                }
                Console.WriteLine();
            }

        }

        public static void Transpose()
        {
            int tmp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[j, i] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void TriangularMatrixTop()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j) matrix[i, j] = 0;
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void TriangularMatrixBottom()
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j) matrix[j, i] = 0;
                    Console.Write(matrix[j, i] + "\t");
                }
                Console.WriteLine();
            }

        }
        public static int Validation()
        {
            string nString = Console.ReadLine();
            int NString;
            if (int.TryParse(nString, out NString))
            {
                return NString;
            }
            else
            {
                Console.WriteLine("Not correct number input again ");
                nString = Console.ReadLine();
                int.TryParse(nString, out NString);
            }
            return NString;
        }
        public static void Menu()
        {
            int i;
            {
                Console.WriteLine("Menu: \n1)Matrix  \n2)Input n and generic new matrix \n3)Finish \n\nYour choice :");

                i = Validation();
                switch (i)
                {
                    case 1:
                        OutputMatrix();

                        break;
                    case 2:
                        GenerixNewMatrix();
                        break;
                    case 3:
                        if (i == 3)
                        {
                            break;
                        }

                        break;
                    default:
                        Console.WriteLine("Not correct, input number again please..");
                        break;
                }
            }

        }
        public static void OutputMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void GenerixNewMatrix()
        {
            Console.Write("Input n: ");
            n = Validation();
            Matrix();
            Console.WriteLine("Transpose: ");
            Optional.Transpose();
            Console.WriteLine("Triangular Matrix Top: ");
            Optional.TriangularMatrixTop();
            Console.WriteLine("Triangular Matrix Bottom: ");
            Optional.TriangularMatrixBottom();
        }

    }
}
