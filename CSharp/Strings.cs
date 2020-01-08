using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public static class Strings
    {
        /// <summary>
        /// Implement a string reversal method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse1(string input)
        {
            var chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Implement a different string reversal method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse2(string input)
        {
            return new string(input.Reverse().ToArray());
        }


        /// <summary>
        /// Implement a string truncation function that safely truncates the input without throwning an exception. Return null if input is null.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string SafeTruncate(string input, int length)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            return input.Length <= length ? input : input.Substring(0, length);
        }

        /// <summary>
        /// return a list of even numbers from the input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int> EvenNumerics(List<string> input)
        {
            var evenIntegers = new List<int>();

            foreach (var testString in input)
            {
                if (!Int32.TryParse(testString, out int intResult))
                    continue;

                if (intResult % 2 == 0)
                    evenIntegers.Add(intResult);
            }

            return evenIntegers;
        }
    }
}
