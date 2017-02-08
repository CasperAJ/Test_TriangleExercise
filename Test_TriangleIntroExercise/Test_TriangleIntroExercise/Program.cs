
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_TriangleIntroExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> trianglesides = new List<int>();
            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("Type in the length of the 3 sides in the triangle.");
                Console.Write("Side A: "); CheckValue(trianglesides);
                Console.Write("Side B: "); CheckValue(trianglesides);
                Console.Write("Side C: "); CheckValue(trianglesides);

                Console.WriteLine(TriangleCheck(trianglesides));
                trianglesides.Clear();

                Console.WriteLine("Click Y for another triangle, click N for closing");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void CheckValue(List<int> list)
        {
            int value = Convert.ToInt32(Console.ReadLine());
            if (value <= 0)
            {
                Console.WriteLine("This is not a valid value for a triangle side. The value must be above 0.");
                Console.Write("Valuie: ");
                value = Convert.ToInt32(Console.ReadLine());
            }
            else list.Add(value);
        }

        static int AddValue()
        {    int side = Convert.ToInt32(Console.ReadLine()); return side;  }

        public static string TriangleCheck(List<int> sides)
        {
            int sidesCount = 0;
            while(sides.Count > 0)
            {
                int currentSide = sides[0];
                sides.Remove(currentSide);
                foreach (var item in sides)
                {
                    if (item == currentSide)
                        sidesCount++;
                }
            }

            if (sidesCount == 3) return "The triangle is an equilateral triangle.";

            if (sidesCount == 1) return "The triangle is an isosceles triangle.";

            if (sidesCount == 0) return "The triangle is an scalene triangle.";

            return "Something went wrong with the calculation, please contact system administrator.";
        }
    }
}
