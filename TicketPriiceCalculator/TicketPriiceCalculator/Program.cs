using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age <= 12 || age >= 65)
            Console.WriteLine("Ticket price: GHC7");
        else
            Console.WriteLine("Ticket price: GHC10");
    }
}
