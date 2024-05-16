using System;
using System.IO;
using System.Linq;

namespace NumberGenerator
{
    ////завдання 1 
    //class Program
    //{
    //    static void Main()
    //    {
    //        var random = new Random();
    //        var numbers = Enumerable.Range(0, 100).Select(_ => random.Next(1, 1000)).ToList();

    //        var primeNumbers = numbers.Where(IsPrime).ToList();
    //        var fibonacciNumbers = GetFibonacciNumbers(numbers.Max()).Where(n => numbers.Contains(n)).ToList();

    //        File.WriteAllLines("prime_numbers.txt", primeNumbers.Select(n => n.ToString()));
    //        File.WriteAllLines("fibonacci_numbers.txt", fibonacciNumbers.Select(n => n.ToString()));

    //        Console.WriteLine($"Generated {numbers.Count} numbers.");
    //        Console.WriteLine($"Found {primeNumbers.Count} prime numbers.");
    //        Console.WriteLine($"Found {fibonacciNumbers.Count} Fibonacci numbers.");
    //    }

    //    static bool IsPrime(int number)
    //    {
    //        if (number <= 1)
    //        {
    //            return false;
    //        }

    //        if (number == 2)
    //        {
    //            return true;
    //        }

    //        if (number % 2 == 0)
    //        {
    //            return false;
    //        }

    //        var boundary = (int)Math.Floor(Math.Sqrt(number));

    //        for (int i = 3; i <= boundary; i += 2)
    //        {
    //            if (number % i == 0)
    //            {
    //                return false;
    //            }
    //        }

    //        return true;
    //    }

    //    static int[] GetFibonacciNumbers(int maxValue)
    //    {
    //        var fibonacciNumbers = new int[maxValue + 1];
    //        fibonacciNumbers[0] = 0;
    //        fibonacciNumbers[1] = 1;

    //        for (int i = 2; i <= maxValue; i++)
    //        {
    //            fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
    //        }

    //        return fibonacciNumbers.TakeWhile(n => n <= maxValue).ToArray();
    //    }
    //}





    ////завдання 2
    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Enter the path to the file:");
    //        string filePath = Console.ReadLine();

    //        Console.WriteLine("Enter the word to search for:");
    //        string searchWord = Console.ReadLine();

    //        Console.WriteLine("Enter the word to replace with:");
    //        string replaceWord = Console.ReadLine();

    //        int searchWordCount = 0;
    //        int replacedWordCount = 0;

    //        try
    //        {
    //            using (StreamReader streamReader = new StreamReader(filePath))
    //            {
    //                string fileContent = streamReader.ReadToEnd();
    //                searchWordCount = fileContent.Split(new string[] { searchWord }, StringSplitOptions.None).Length - 1;

    //                fileContent = fileContent.Replace(searchWord, replaceWord);
    //                replacedWordCount = searchWordCount;

    //                using (StreamWriter streamWriter = new StreamWriter(filePath))
    //                {
    //                    streamWriter.Write(fileContent);
    //                }
    //            }

    //            Console.WriteLine($"The word '{searchWord}' was found {searchWordCount} times.");
    //            Console.WriteLine($"The word '{searchWord}' was replaced with '{replaceWord}' {replacedWordCount} times.");
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"An error occurred: {ex.Message}");
    //        }

    //        Console.ReadLine();
    //    }
    //}




    ////завдання 3
    //class Program
    //{
    //    static string[] LoadWords(string filePath)
    //    {
    //        return File.ReadAllLines(filePath);
    //    }

    //    static string ModerateText(string inputFilePath, string moderationFilePath)
    //    {
    //        string[] moderatedWords = LoadWords(moderationFilePath);

    //        string text = File.ReadAllText(inputFilePath);

    //        foreach (var word in moderatedWords)
    //        {
    //            text = text.Replace(word, "*");
    //        }

    //        return text;
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine("Enter the path to the input file:");
    //        string inputFilePath = Console.ReadLine();

    //        Console.WriteLine("Enter the path to the word file for moderation:");
    //        string moderationFilePath = Console.ReadLine();

    //        string moderatedText = ModerateText(inputFilePath, moderationFilePath);

    //        Console.WriteLine("Enter the path to save the moderated text:");
    //        string outputFilePath = Console.ReadLine();

    //        File.WriteAllText(outputFilePath, moderatedText);

    //        Console.WriteLine("Moderated text saved successfully.");
    //    }
    //}



    //завдання 4
    class Program
    {
        static void ModerateText(string textFile, string moderationFile)
        {
            string[] moderateWords = File.ReadAllLines(moderationFile);

            string text = File.ReadAllText(textFile);

            foreach (string word in moderateWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            File.WriteAllText(textFile, text);
        }

        static void Main()
        {
            Console.Write("Enter the path to the text file: ");
            string textFile = Console.ReadLine();

            Console.Write("Enter the path to the moderation file: ");
            string moderationFile = Console.ReadLine();

            ModerateText(textFile, moderationFile);
            Console.WriteLine("Moderation completed successfully.");
        }
    }
}