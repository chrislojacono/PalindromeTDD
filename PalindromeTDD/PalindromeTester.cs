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
            if (input == input.Reverse())
            {
                return true;
            }
            return false;
        }
    }
}
