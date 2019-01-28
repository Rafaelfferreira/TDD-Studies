using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculatorKata
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (!string.IsNullOrEmpty(numbers)) //test if the input is not empty.
            {
                List<string> ListaDelimitador = new List<string>();

                if (numbers[0] == '/') //if there is a specific delimitador other than "," and "\n"
                {
                    int i = 2; //index of the first digit of the delmitador
                    while (numbers[i] != '\n') //until it finds "\n"
                    {
                        ListaDelimitador.Add(System.Convert.ToString(numbers[i]));
                        i++;
                    }

                    numbers = numbers.Substring(i + 1); //split the string into the substring without the delimitador
                }
                else
                    ListaDelimitador.Add(",");

                string delimitador = String.Join("", ListaDelimitador); //joins the itens on ListaDelimitador into a single string
                numbers = numbers.Replace("\n", delimitador); //substitutes all line breaks with commas
                string[] digits = Regex.Split(numbers, delimitador);
                
                int sum = 0;
                
                for(int i=0; i<digits.Length; i++)
                {
                    if (System.Convert.ToInt32(digits[i]) >= 0)
                        sum += System.Convert.ToInt32(digits[i]); //adds each number to the int sum
                    else
                        throw new System.ArgumentException("Digits can not be negative numbers");
                }
                return sum;
            }
            else //if the input is empty returns 0.
                return 0;
        }

    }
}
