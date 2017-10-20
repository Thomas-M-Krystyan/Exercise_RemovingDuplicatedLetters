using System.Collections.Generic;
using System.Text;

namespace RemoveDuplicatedLetters
{
    internal static class StringAnalyzer
    {
    // Solution with handmade implementation of HashSet collection and StringBuilder
    #region First algorithm
        internal static string ReplaceDuplicatedLetters1(string textData)
        {
            // List of skipped (already used) letters
            List<char> usedLetters = new List<char>();

            // New string without duplicated letters
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char letter in textData.ToLower())
            {
                if (usedLetters.Contains(letter))
                {
                    continue;
                }
                stringBuilder.Append(letter);
                usedLetters.Add(letter);
            }

            return stringBuilder.ToString();
        }
    #endregion

    // Faster solution with using already built-in HashSet collection and concatenation
    #region Second algorithm
        internal static string ReplaceDuplicatedLetters2(string textData)
        {
            // Create unique collection of letters
            HashSet<char> uniqueLetters = new HashSet<char>();
            foreach (char letter in textData.ToLower())
            {
                uniqueLetters.Add(letter);
            }

            // Convert content of HashSet into string
            return string.Join("", uniqueLetters);
        }
    #endregion
    }
}
