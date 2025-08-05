using System;

class TriangleTypeApp
{
    static void Main()
    {
        double side1, side2, side3;

        Console.WriteLine("Enter the lengths of the triangle: ");

        Console.Write("Side 1: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 2: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 3: ");
        side3 = Convert.ToDouble(Console.ReadLine());

        if (TriangleType(side1, side2, side3))
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
        else
        {
            Console.WriteLine("The values entered do not form a triangle.");
        }
    }

    static bool TriangleType(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
