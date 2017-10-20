using System;

namespace RemoveDuplicatedLetters
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Remove duplicated letters\n(List algorithm):\n");
            Console.WriteLine(StringAnalyzer.ReplaceDuplicatedLetters1("Ananas"));
            Console.WriteLine(StringAnalyzer.ReplaceDuplicatedLetters1("Banana"));
            Console.WriteLine(StringAnalyzer.ReplaceDuplicatedLetters1("Coconut"));

            Console.WriteLine("\n" + new string('-', 30));

            Console.WriteLine("\nRemove duplicated letters\n(HashSet algorithm):\n");
            Console.WriteLine(StringAnalyzer.ReplaceDuplicatedLetters2("Ananas"));
            Console.WriteLine(StringAnalyzer.ReplaceDuplicatedLetters2("Banana"));
            Console.WriteLine(StringAnalyzer.ReplaceDuplicatedLetters2("Coconut"));

            Console.ReadLine();
        }
    }
}
