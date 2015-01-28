namespace Enter_Numbers
{
    using System;
    static class NumberValidator
    {
        static void Main()
        {
            var start = 1;
            const int end = 100;

            Console.WriteLine(
                "Please enter 10 number is the range [{0}..{1}]:",
                start,
                end);

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.Write(
                        "No. {0} --> ",
                        (i + 1).ToString("D2"));

                    start = ReadNumber(start, end);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine(
                        "The number you entered is not in the range [{0}..{1}]. Please try again!",
                        start,
                        end);

                    i = i - 1;
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine(
                       "The number you entered is not valid. Please enter a number in the range [{0}..{1}]!",
                       start,
                       end);

                    i = i - 1;
                }
                catch (OverflowException)
                {
                    Console.Error.WriteLine(
                       "The number you entered is too big. Please enter a number in the range [{0}..{1}]!",
                       start,
                       end);

                    i = i - 1;
                }
            }

            Console.WriteLine(
                "End of program. Bye bye!");
        }

        static int ReadNumber(int start, int end)
        {
            Console.Write(
                "Please enter a number in the range [{0}..{1}]: ",
                start,
                end);

            var consoleReader = Console.ReadLine();
            var number = 0;

            if (!string.IsNullOrEmpty(consoleReader))
            {
                number = Int32.Parse(consoleReader);

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }

            return number;
        }
    }
}
