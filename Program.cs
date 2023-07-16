using System;

namespace AverageWordLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            double averageLength = CalculateAverageWordLength(input);
            double roundedAverageLength = Math.Round(averageLength, 3);

            Console.WriteLine("Average word length: " + roundedAverageLength);
        }

        static double CalculateAverageWordLength(string input)
        {
            string[] words = input.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int totalLength = 0;

            foreach (string word in words)
            {
                totalLength += word.Length;
            }

            return (double)totalLength / words.Length;
        }
    }
}
