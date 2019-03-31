using System;
using System.Collections.Generic;

namespace WordJuggle
{
    static class Program
    {
        public static void Main(string[] args)
        {
            //var wordToBeJuggled = "JAVA";
            //var splitWord = wordToBeJuggled.ToCharArray();
            //Array.Sort(splitWord);
            //var sortWord = string.Join("", splitWord);
            int i = 0;
            foreach (string word in Permutations.GetAll("AAJV"))
            {
                Console.WriteLine("{0}. {1}", ++i, word);
            }
            Console.ReadLine();
        }

        public static void Assert(bool result, string message)
        {
            Console.WriteLine("ASSERT: {0}: {1}", result ? "PASS" : "FAIL", message);
        }

        public static class Permutations
        {
            static readonly List<string> _emptyList = new List<string>();

            public static IEnumerable<string> GetAll(string text)
            {
                if (string.IsNullOrWhiteSpace(text)) { return _emptyList; }

                if (text.Length == 1) { return new List<string>() { text }; }

                if (text.Length == 2) { return new List<string>() { text, Reverse(text) }; }

                return insertSuffix(GetAll(text.Substring(0, text.Length - 1)), text[text.Length - 1]);
            }


            private static string Reverse(string text)
            {
                char[] reverse = text.ToCharArray();
                Array.Reverse(reverse);
                return new string(reverse);
            }

            private static IEnumerable<string> insertSuffix(IEnumerable<string> permutations, char suffix)
            {
                List<string> newPermutations = new List<string>();

                foreach (string word in permutations)
                {
                    for (int i = 0; i <= word.Length; i++)
                    {
                        string newWord = word.Insert(i, suffix.ToString());
                        newPermutations.Add(newWord);
                    }
                }

                return newPermutations;
            }

        }
    }
}
