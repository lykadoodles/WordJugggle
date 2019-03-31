﻿using System;
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
            var splitWord = wordToBeJuggled.ToCharArray();
            Array.Sort(splitWord);
            var sortWord = string.Join("", splitWord);
            var finalDistinctJugglet = GetPermutations(sortWord);
            Console.WriteLine("=== FINAL DISTINCT JUGGLET OUTPUT ===");
            Console.WriteLine(finalDistinctJugglet);
            Console.WriteLine("Press any key to exit");
        }
        private static char[] _characters;
        private static List<string> _list;

        public static IEnumerable<string> GetPermutations(string characters)
        {
            _characters = characters.ToCharArray();
            _list = new List<string>();
            AddPermutations("", 0);
            return _list;
        }

        private static void AddPermutations(string permutation, int level)
        {
            if (level >= _characters.Length)
            {
                _list.Add(permutation);
            }
            else
            {
                for (int i = 0; i < _characters.Length; i++)
                {
                    char ch = _characters[i];
                    if (ch != ' ')
                    {
                        _characters[i] = ' ';
                        AddPermutations(permutation + ch, level + 1);
                        _characters[i] = ch;
                    }
                }
            }
        }
    }
}
