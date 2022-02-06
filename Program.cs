using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateAlphabet());
            string backwards = CreateAlphabetBackwards();
            Console.WriteLine(backwards);
            Console.Write("How many letters would you like to skip: ");
            string userInput = Console.ReadLine();
            int numberToSkip = int.Parse(userInput);
            string skipOne = CreateAlphabetSkip(numberToSkip);
            Console.WriteLine(skipOne);
            //string skipOne =CreateAlphabetSkip(2);
            //Console.WriteLine(skipOne);
        }
        static string CreateAlphabet()
        {
            string alphabet = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                alphabet += alpha;
            }
            return alphabet;

        }
        static string CreateAlphabetBackwards()
        {
            string alphabetBackwards = string.Empty;
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                alphabetBackwards += alpha;
            }
            return alphabetBackwards;
        }
        static string CreateAlphabetSkip(int skip)
        {
            string alphabetSkip = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha = (char)(alpha + skip))
            {
                alphabetSkip += alpha;
            }
            return alphabetSkip;
        }
    }
}
