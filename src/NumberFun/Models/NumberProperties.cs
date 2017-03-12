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

            return true;
        }

        public bool isPerfect()
        {
            return true;
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
