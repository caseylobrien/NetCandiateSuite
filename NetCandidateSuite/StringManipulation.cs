using System;
using System.Collections.Generic;
using System.Text;

namespace NetCandidateSuite
{
    public class StringManipulation
    {
        #region GetCharAt
        /// <summary>
        /// Write a method that takes the input string and returns a character at the position of charAt
        /// </summary>
        /// <param name="input">The string to return the character from</param>
        /// <param name="charAt">The position of the charater to return</param>
        /// <returns> A <see cref="Char"/> at the provided location in the string</returns>
        /// <remarks>
        /// Example: input: "hello", charAt: 2, returns: 'e'
        /// Example: input: "hello", charaAt: 5, returns: 'o'
        /// Example: input: "hello", charaAt: 11, returns: 'h'
        /// </remarks>
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
        #endregion

        #region ReverseWithDash
        /// <summary>
        /// Write a method to reverse the input string and seperate each character by a dash (i.e. '-')
        /// </summary>
        /// <param name="input">The string to reverse</param>
        /// <returns>A <see cref="String"/> that is reversed with dashes between each character</returns>
        /// <remarks>
        /// Example: input: "hello", returns: "o-l-l-e-h"
        /// </remarks>
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
        #endregion
    }
}
