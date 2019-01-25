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
                numbers = numbers.Replace("\n", ","); //substitutes all line breaks with commas
                List<string> digits = numbers.Split(',').ToList(); //converts the entry string into a list of string separated by commas
                
                int sum = 0;
                
                for(int i=0; i<digits.Count; i++)
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
