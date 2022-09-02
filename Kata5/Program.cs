using System;

//A Narcissistic Number is a positive number which is the sum of its own digits, 
//each raised to the power of the number of digits in a given base. 
//In this Kata, we will restrict ourselves to decimal (base 10).

//For example, take 153 (3 digits), which is narcisstic:

//    1 ^ 3 + 5 ^ 3 + 3 ^ 3 = 1 + 125 + 27 = 153
//and 1652(4 digits), which isn't:

//    1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938
//The Challenge:

//Your code must return true or false (not 'true' and 'false')
//depending upon whether the given number is a Narcissistic number in base 10. 
//This may be True and False in your language, e.g. PHP.

//Error checking for text strings or other invalid inputs is not required,
//only valid positive non-zero integers will be passed into the function.

namespace Kata5
{
    public class Kata
    {
        public static bool Narcissistic(  int value)
        {
           double x = 0;
           string small = Convert.ToString(value);
           Console.WriteLine(small.Length);
            
                foreach(int v in small)
                {
                  int q = v - 48;
                    Console.WriteLine("v is now {0}", q);
                    x += Math.Pow(q, small.Length);
                    Console.WriteLine( "The sum is now {0}", x);
                }
            //  Console.WriteLine(x);

            if (value == Math.Round(x))
            {
                return true;
            }
            else
                return false;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.Narcissistic(1652));
        }
    }
}
