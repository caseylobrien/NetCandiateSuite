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

        public static string ReverseWithDash(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }
            var maxLength = input.Length * 2 - 1;
            var sb = new StringBuilder(maxLength);

            for (var i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
                if (!(i <= 0))
                {
                    sb.Append("-");
                }
            }
            
            return sb.ToString();
        }
    }
}
