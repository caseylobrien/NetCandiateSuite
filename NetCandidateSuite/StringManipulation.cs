using System;
using System.Collections.Generic;
using System.Text;

namespace NetCandidateSuite
{
    public class StringManipulation
    {
        public static char GetCharAt(string input, int charAt)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }
            if (charAt <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var mod = charAt % input.Length;

            if(mod == 0)
            {
                return input[input.Length - 1];
            }
            else
            {
                return input[mod - 1];
            }
        }
    }
}
