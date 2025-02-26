using System;

namespace ControlFlowExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: "); // 5
            var number = Convert.ToInt32(Console.ReadLine()); // 5
            var factorial = 1; // 1
            for (var i = 1; i <= number; i++) // 1, 2, 3, 4, 5
            {
                factorial *= i; // 1, 2, 6, 24, 120
            }
            Console.WriteLine("{0}! = {1}", number, factorial); // 5! = 120
        }
    }
}
