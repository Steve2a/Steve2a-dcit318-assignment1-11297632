using System;

namespace GradeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your numerical grade (0 - 100):");
            string input = Console.ReadLine();

            int numericalGrade = Convert.ToInt32(input);

            GradeCalculator calculator = new GradeCalculator ();

            calculator.NumericalGrade = numericalGrade;

            string letterGrade = calculator.CalcLetterGrade();

            Console.WriteLine($"Your letter grade is {letterGrade}");
        }
    }
}