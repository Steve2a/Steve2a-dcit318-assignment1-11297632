using System;

namespace TicketCalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter your age: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    if (age < 0 || age > 120)
    {
        Console.WriteLine("Invalid age entered. Please enter a number between 0 and 120.");
    }
    else
    {
        TicketCalculator ticket = new TicketCalculator();
        ticket.Age = age;

        int price = ticket.CalcPrice();
        Console.WriteLine($"Your ticket price is GHC{price}");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a numeric value.");
}
    }
}
}