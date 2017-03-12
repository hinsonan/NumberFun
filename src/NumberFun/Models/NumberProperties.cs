using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberFun.Models
{
    public class NumberProperties
    {
        public int Number { get; set; }
        public NumberProperties(int num)
        {
            Number = num;
        }

        public bool isPrime()
        {
            int modCount = 0;
            for(int i = 1; i <= Number; i++)
            {
                if(Number % i == 0)
                {                    
                    modCount++;
                }
            }
            if (modCount == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public bool isPerfect()
        {
            int sum = 0;
            for (int i = 1; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isSquareful()
        {
            return true;
        }

        public bool isPowerful()
        {
            return true;
        }

        public bool isPalindrome()
        {
            return true;
        }
    }
}
