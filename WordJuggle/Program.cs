using System;
using System.Collections.Generic;

namespace WordJuggle
{
    static class Program
    {
        public static void Main()
        {
            Console.Write("Please input word to be juggled: ");
            string inputWord = Console.ReadLine();
            char[] wordToBeJuggled = inputWord.ToCharArray();
            Array.Sort(wordToBeJuggled);
            int wordLength = wordToBeJuggled.Length;
            wordJuggle(wordToBeJuggled, 0, wordLength);
            Console.ReadLine();
        }

        static bool isJuggleReady(char[] word,
                               int start, int current)
        {
            for (int i = start; i < current; i++)
            {
                if (word[i] == word[current])
                {
                    return false;
                }
            }
            return true;
        }

        static void wordJuggle(char[] word,
                                     int index, int max)
        {
            if (index >= max)
            {
                Console.WriteLine(word);
                return;
            }

            for (int i = index; i < max; i++)
            { 
                bool isReadyToJuggle = isJuggleReady(word, index, i);
                if (isReadyToJuggle)
                {
                    juggleNow(word, index, i);
                    wordJuggle(word, index + 1, max);
                    juggleNow(word, index, i);
                }
            }
        }

        static void juggleNow(char[] word, int currentLetterIndex, int nextLetterIndex)
        {
            char letter = word[currentLetterIndex];
            word[currentLetterIndex] = word[nextLetterIndex];
            word[nextLetterIndex] = letter;
        }
        
    }

}
