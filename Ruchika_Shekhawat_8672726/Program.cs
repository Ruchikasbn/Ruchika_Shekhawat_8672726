using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Ruchika_Shekhawat_8672726
{

    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                int sidea, sideb, sidec, menu;

                Console.Write("\n Check whether a triangle is Equilateral, Isosceles or Scalene:\n");
                Console.Write("----------------------------------------------------------------\n");

                Console.Write("1: Enter Traingle Dimension\n");

                Console.Write("2: Exit\n");

                menu = Convert.ToInt32(Console.ReadLine());


                if (menu == 1)

                {
                    TriangleSolver.Analyze(out sidea, out sideb, out sidec);
                }
                else if (menu == 2)
                {
                    Environment.Exit(0);
                }
                else

                {
                    Console.WriteLine("Invalid Input\n");

                }


            }
            while (true);
        }



        static class TriangleSolver
        {
            public static void Analyze(out int sidea, out int sideb, out int sidec)
            {
                Console.Write("Input side 1 of triangle: ");
                sidea = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 2 of triangle: ");
                sideb = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 3 of triangle: ");
                sidec = Convert.ToInt32(Console.ReadLine());



                if (sidea == sideb && sideb == sidec)
                {
                    Console.Write("This is an equilateral triangle.\n");
                }
                else if (sidea == sideb || sidea == sidec || sideb == sidec)
                {
                    Console.Write("This is an isosceles triangle.\n");
                }
                else
                {
                    Console.Write("This is a scalene triangle.\n");
                }
            }

        }



    }
}