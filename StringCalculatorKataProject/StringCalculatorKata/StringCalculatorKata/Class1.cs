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
                List<string> delimitadores = new List<string>() { "," };

                if (numbers[0] == '/') //if there is a specific delimitador other than "," and "\n"
                {
                    if (numbers[2] == '[') //multiple delimitadors
                    {
                        int i = 2; //index of the first [
                        while (numbers[i] != '\n') //until it finds "\n" (the end of the delimitador list)
                        {
                            ListaDelimitador = new List<string>();
                            do
                            {
                                if(numbers[i] != '[')
                                    ListaDelimitador.Add(System.Convert.ToString(numbers[i]));
                                i++;
                            } while (numbers[i] != ']'); //until it finds "]" (the end of the first delimitador)

                                delimitadores.Add(String.Join("", ListaDelimitador));
                                i++;
                        }

                        numbers = numbers.Substring(i + 1); //split the string into the substring without the delimitador

                    }
                    else //only one custom delimitador
                    {
                        int i = 2; //index of the first digit of the delmitador
                        while (numbers[i] != '\n') //until it finds "\n"
                        {
                            ListaDelimitador.Add(System.Convert.ToString(numbers[i]));
                            i++;
                        }

                        numbers = numbers.Substring(i + 1); //split the string into the substring without the delimitador

                        delimitadores.Add(String.Join("", ListaDelimitador)); //joins the itens on ListaDelimitador into a single string
                    }
                }

                string oldDel = "\n"; //var used to sort through all the delimitador on the string
                for(int i=0; i < delimitadores.Count; i++)
                {
                    numbers = numbers.Replace(oldDel, delimitadores[i]); //substitutes all delimitadors with the last one available
                    oldDel = delimitadores[i];
                }
                
                string[] digits = Regex.Split(numbers, delimitadores[delimitadores.Count-1]);
                
                int sum = 0;
                
                for(int i=0; i<digits.Length; i++)
                {
                    if (System.Convert.ToInt32(digits[i]) < 1001 && System.Convert.ToInt32(digits[i]) > 0)
                        sum += System.Convert.ToInt32(digits[i]); //adds each number to the int sum
                    else if (System.Convert.ToInt32(digits[i]) < 0)
                        throw new System.ArgumentException("Digits can not be negative numbers");
                }
                return sum;
            }
            else //if the input is empty returns 0.
                return 0;
        }

    }
}
