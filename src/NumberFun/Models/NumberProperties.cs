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

        //this method will be used in the isPowerful method
        private bool isPrime(int num)
        {
            int modCount = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
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
            for (int i = 1; i <= Number; i++)
            {
                //if the number is evenly divisible by i do this
                if (Number % i == 0)
                {
                    //if i is a prime number check if i^2 is divides evenly into Number
                    if (isPrime(i) == true)
                    {
                        //if the i^2 does not divide evenly then the number is squareful
                        if (Number % (i * i) == 0)
                        {
                            return true;
                        }

                    }
                }
            }
            return false;
        }

        public bool isPowerful()
        {
            for(int i = 1; i <= Number; i++)
            {
                //if the number is evenly divisible by i do this
                if(Number % i == 0)
                {
                    //if i is a prime number check if i^2 is divides evenly into Number
                    if(isPrime(i) == true)
                    {
                        //if the i^2 does not divide evenly then the number is not powerful
                        if(Number % (i*i) != 0)
                        {
                            return false;
                        }
                        
                    }
                }
            }
            return true;
        }

        public bool isPalindrome()
        {
            int num = Number;
            int remainder;
            int reverse = 0;
            int temp;

            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }

            if (temp == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
                
            
        }
    }
}
