using System;

namespace Permutations
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String str = "JAVA";
            int n = str.Length;
            permute(str, 0, n - 1);
            Console.ReadLine();
        }
        private static void permute(String str,
                            int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }

        public static String swap(String a,
                                  int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
