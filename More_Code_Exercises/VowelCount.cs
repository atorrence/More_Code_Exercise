using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Code_Exercises
{
    public class VowelCount
    {
        // Return the number(count) of vowels in the given string.
        //We will consider a, e, i, o, and u as vowels for this Kata.
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            str = str.ToLower();
            // Your code here

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i,1) == "a")
                {
                    vowelCount++;
                }
                if (str.Substring(i, 1) == "e")
                {
                    vowelCount++;
                }
                if (str.Substring(i, 1) == "i")
                {
                    vowelCount++;
                }
                if (str.Substring(i, 1) == "o")
                {
                    vowelCount++;
                }
                if (str.Substring(i, 1) == "u")
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
