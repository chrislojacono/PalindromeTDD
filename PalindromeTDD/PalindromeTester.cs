using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeTDD
{
    public class PalindromeTester
    {
        public bool Tester(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reversedString = new string(charArray);
            if (input.Equals(reversedString, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
