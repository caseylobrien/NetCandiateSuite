using System;
using System.Collections.Generic;
using System.Text;

namespace NetCandidateSuite
{
    public class StringManipulation
    {
        public static char GetCharAt(string input, int charAt)
        {
            if (!String.IsNullOrEmpty(input) && charAt > 0)
            {
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
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
