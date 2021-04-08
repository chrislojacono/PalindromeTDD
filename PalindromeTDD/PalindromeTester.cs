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
            var joinedInput = string.Concat(input.Where(c => !char.IsWhiteSpace(c)));

            char[] inputCharArray = joinedInput.ToCharArray();
            char[] charArray = joinedInput.ToCharArray();

            Array.Reverse(charArray);

            var nonresversedStringWithPunctuationRemoved = new string(inputCharArray.Where(c => !char.IsPunctuation(c)).ToArray());
            var reversedStringWithPunctuationRemoved = new string(charArray.Where(c => !char.IsPunctuation(c)).ToArray());
            
            if (nonresversedStringWithPunctuationRemoved.Equals(reversedStringWithPunctuationRemoved, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
