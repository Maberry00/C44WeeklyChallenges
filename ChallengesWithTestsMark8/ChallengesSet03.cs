using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals) 
            {
                if (item == false) 
                {
                    return true;
                }
            }
            return false;
            //return vals != null && vals.Length != && vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           bool isLetter = false;
           bool isDigit = false;
           bool isUpper = false;

           foreach (var letter in password) 
            {
                if (char.IsLower(letter)) 
                {
                    isLetter = true;
                }
                if (char.IsDigit(letter)) 
                {
                    isDigit = true;
                }
                if (char.IsUpper(letter)) 
                {
                    isUpper = true;
                }
            }

           return isLetter && isDigit && isUpper;


        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1,100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
