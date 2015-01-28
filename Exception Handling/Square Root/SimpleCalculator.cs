namespace Square_Root
{
    using System;

    static class SimpleCalculator
    {
        static void Main()
        {
            try
            {
                var consoleReader = Console.ReadLine();

                if (!string.IsNullOrEmpty(consoleReader))
                {
                    var number = Int32.Parse(consoleReader);
                    var answer = CalculateSquareRoot(number);
                    Console.WriteLine(answer);
                }
            }
            catch (FormatException formatException)
            {
                Console.Error.WriteLine(
                    "Invalid number!");
            }
            catch (ArithmeticException arithmeticException)
            {
                Console.Error.WriteLine(arithmeticException.Message);
            }
            finally
            {
                Console.WriteLine(
                    "Good bye");
            }
        }

        static double CalculateSquareRoot(int number)
        {
            if (number < 0)
            {
                throw new ArithmeticException(
                    "Negative number!");
            }

            var output = Math.Sqrt(number);

            return output;
        }
    }
}
