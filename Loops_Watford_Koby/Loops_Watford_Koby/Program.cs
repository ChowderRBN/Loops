namespace Loops_Watford_Koby
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Counting spaces in a string
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            // Part 2: Summing the digits of a number
            Console.WriteLine("\nEnter a number to sum its digits:");
            string numberInput = Console.ReadLine();
            int sumOfDigits = SumDigits(numberInput);
            Console.WriteLine($"The number {numberInput} has a digit sum of {sumOfDigits}.");
        }

        // Method to count the spaces in a string
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach (char character in sentence)
            {
                if (character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        // Method to sum the digits of a given number (as a string)
        static int SumDigits(string number)
        {
            int sum = 0;
            foreach (char character in number)
            {
                if (Char.IsDigit(character))  // Ensure we're only adding digits
                {
                    sum += (int)Char.GetNumericValue(character);
                }
            }
            return sum;
        }
    }
}
