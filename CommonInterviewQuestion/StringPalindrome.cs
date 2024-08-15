using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreperation
{
    public class StringPalindrome
    {
        public static void Main(string[] args)
        {
            string palindrome = "Aqweb ! aewqa !";
            var result = IsPalindrome(palindrome);
        }

        public static bool IsPalindrome(string str)
        {
            int indexFromStart = 0;
            int indexFromLast = str.Length-1;
            str = str.ToLower();
            while (indexFromStart <= indexFromLast)
            {
                if(!(str[indexFromStart] >= 'a' && str[indexFromStart] <= 'z'))
                {
                    indexFromStart++;
                }

                else if(!(str[indexFromLast] >= 'a' && str[indexFromLast] <= 'z'))
                {
                    indexFromLast--;
                }

                else if(str[indexFromLast] == str[indexFromStart])
                {
                    indexFromLast--;
                    indexFromStart++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
