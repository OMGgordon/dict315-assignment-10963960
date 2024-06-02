using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side 1 of the triangle: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 2 of the triangle: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 3 of the triangle: ");
        int side3 = int.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Triangle type: Equilateral");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("Triangle type: Isosceles");
        else
            Console.WriteLine("Triangle type: Scalene");
    }
}
