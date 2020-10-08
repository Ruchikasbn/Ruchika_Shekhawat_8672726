using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Ruchika_Shekhawat_8672726
{

    public class Program
    {
        static void Main(string[] args)
        {

            do
            {
                // comment added
                int sidea, sideb, sidec, menu;

               Console.Write("\n Check whether a triangle is Equilateral, Isosceles or Scalene:\n");
                Console.Write("----------------------------------------------------------------\n");

                Console.Write("1: Enter Traingle Dimension\n");

                Console.Write("2: Exit\n");

                menu = Convert.ToInt32(Console.ReadLine());


                if (menu == 1)

                {
                    Console.Write("Input side 1 of triangle: ");
                    sidea = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Input side 2 of triangle: ");
                    sideb = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Input side 3 of triangle: ");
                    sidec = Convert.ToInt32(Console.ReadLine());

                    if (sidea + sideb <= sidec || sidea + sidec <= sideb || sideb + sidec <= sidea)
                    {

                        var result = TriangleSolver.Analyze(sidea, sideb, sidec);
                        Console.WriteLine(result);
                    }
                    else
                    { Console.Write("Invalid triangle");
                    }
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



      public  static class TriangleSolver
        {
            public static string Analyze(int sidea, int sideb, int sidec)
            {

               
                   

                        if (sidea == sideb && sideb == sidec)
                        {
                            return "This is an equilateral triangle.";
                        }
                        else if (sidea == sideb || sidea == sidec || sideb == sidec)
                        {
                            return "This is an isosceles triangle.\n";
                        }
                        else if (sidea != sideb || sidea != sidec || sideb != sidec)
                        {
                            return "This is a scalene triangle.\n";
                        }
                        else
                        {
                            return "\nInvalid input";
                       
                       }
                        
                }
        }



    }
}