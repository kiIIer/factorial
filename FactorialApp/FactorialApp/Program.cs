using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialApp
{
    class Program
    {
        static void Main()
        {
            var program = new Program();

            while (true)
            {
                Console.WriteLine("To exit enter 'x'.");
                Console.WriteLine("Please provide ordinal of a Factorial number:");

                var ordinalText = Console.ReadLine();

                if (ordinalText == "x") return;

                if (!int.TryParse(ordinalText, out var ordinal))
                {
                    Console.WriteLine("Entered value is not a number!");
                    continue;
                }

                if (ordinal < 1)
                {
                    Console.WriteLine("Enter a positive number!");
                    continue;
                }

                try
                {
                    var factorialNumber = program.GetFactorialNumber(ordinal);

                    Console.WriteLine("Factorial({0:N0}) = {1:N0}", ordinal, factorialNumber);
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"An error occured: {exception.Message}");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

        }

        ulong GetFactorialNumber(int ordinal)
        {
            if (ordinal < 1) throw new ArgumentOutOfRangeException(nameof(ordinal), ordinal, "Argument is less than minimum value of 1.");

            ulong factorial = 1;

            for (int i = 0; i < ordinal; i++)
            {
                factorial = checked(factorial * (ulong)(i + 1));
            }

            return factorial;
        }
    }
}
