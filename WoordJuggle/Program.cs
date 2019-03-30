using System;
using System.Collections.Generic;
using System.Linq;

namespace WoordJuggle
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Jugggle");

            
            var wordToBeJuggled = "JAVA";
            var splitWord = wordToBeJuggled.Split("");
            Array.Sort(splitWord);
            var sortWord = string.Join("", splitWord);
            var finalDistinctJugglet = WordJugggle(sortWord);
            Console.WriteLine("=== FINAL DISTINCT JUGGLET OUTPUT ===");
            Console.WriteLine(finalDistinctJugglet);
            Console.WriteLine("Press any key to exit");
        }
        private static IList<string> WordJugggle(string word)
        {
            var juggledLetter = new List<string>();
            var distinctJugglet = new List<string>();
            var availableLetter = "";

            for (var i = 0; i < word.Length; i++)
            {
                availableLetter = word.Substring(i, 1);

                //add to the juggled letters list
                juggledLetter.Add(availableLetter);

                //measure if word length has reached 0 then WordJugggleDistinct the juggled word
                if (word.Length == 0)
                {
                    var juggledWord = String.Join("", juggledLetter);
                    if (WordJugggleDistinct(juggledWord))
                    {
                        distinctJugglet.Add(juggledWord);
                        Console.WriteLine(distinctJugglet + " Distinctive Juggle List");
                    }
                }
                else
                {
                    //else keep jugglin on the remaining letters available
                    WordJugggle(word);
                }
                word.splice(i, 0, availableLetter);

                //remove juggled already letters
                juggledLetter.RemoveAt(0);
            }

            return distinctJugglet;
        }

        private static bool WordJugggleDistinct(string juggledWord)
        {
            var isDistinct = true
            found = distinctJugglet.filter(x => x == juggledWord).length;
            if (found > 0)
                isDistinct = false;

            return isDistinct;
        }
    }
}
