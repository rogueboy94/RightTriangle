using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traingle
{
    class RightTriangle {
        float sideA, sideB, sideC;
        public RightTriangle( float a, float b, float c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public float Area()
        {
            return sideA * sideB / 2;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n           /|B");
            Console.WriteLine("          / | ");
            Console.WriteLine("         /  | ");
            Console.WriteLine("        /   | ");
            Console.WriteLine("       /    | ");
            Console.WriteLine("     A/____П|C\n");
            Console.WriteLine("Enter AC side of a right triangle");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter BC side of a right traingle");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter AB side of a right traingle");
            float c = float.Parse(Console.ReadLine());

            RightTriangle t1 = new RightTriangle(a,b,c);

            Console.WriteLine("Area of a Right Triangle:" + t1.Area());
        }
    }
}
