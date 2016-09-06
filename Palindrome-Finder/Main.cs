using System.Text.RegularExpressions;

namespace PalindromeFinder
{
    public class FindPalindrome
    {
   
        public bool isPalindrome(string stringToCheck, string charctersToIgnore)
        {
            stringToCheck = stringToCheck.ToLower();
            string sanitizedInput = Regex.Replace(stringToCheck, @"\s|["+ charctersToIgnore +"]", "");
            
            int reverseStringLocation = sanitizedInput.Length -1;

            for (int i = 0; i != reverseStringLocation; i++, reverseStringLocation--)
            {
                if(sanitizedInput[i] == sanitizedInput[reverseStringLocation])
                {

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
