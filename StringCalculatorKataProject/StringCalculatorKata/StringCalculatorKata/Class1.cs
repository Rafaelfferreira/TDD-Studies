using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (!string.IsNullOrEmpty(numbers)) //test if the input is not empty.
            {
                List<string> digits = numbers.Split(',').ToList(); //converts the entry string into a list of string separated by commas
                int sum = 0;

                int range = digits.Count; //keeps track of how many itens there are on the array
                if (digits.Count > 2) //it it has more than 2 disregard the ones beyond 2
                    range = 2;

                for(int i=0; i<range; i++)
                {
                    sum += System.Convert.ToInt32(digits[i]); //adds each number to the int sum
                }
                return sum;
            }
            else //if the input is empty returns 0.
                return 0;
        }

    }
}
