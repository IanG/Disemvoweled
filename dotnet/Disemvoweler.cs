using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Disemvoweling
{
    public class Disemvowler
    {
        private readonly static IEnumerable<char> vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        private readonly static IEnumerable<char> nonconsonants = new char[] { ' ' };
        public static string Disemvowel(string input)
        {
            return new String(input.ToCharArray()
                .Where(c => !vowels.Contains(c) && !nonconsonants.Contains(c))
                .ToArray());
        }

        public static string GetVowels(string input)
        {
            return new String(input.ToCharArray()
                .Where(c => vowels.Contains(c))
                .ToArray());
        }
    }
}
