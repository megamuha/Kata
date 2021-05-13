using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kata
{
    public class Calculator
    {
        //Сумма без параметров
        public int Add()
        {
            return 0;
        }

        //Сумма с параметом
        public int Add(string StringOfNumbers)
        {
            int amount = 0;
            List<string> list = new List<string>();

            if (StringOfNumbers.Length == 1)
            {
                return Int32.Parse(StringOfNumbers);
            }
            
            else
            {
                //Переобразование строки в массив чисел
                string[] ArrayOfStrings = TrimString(StringOfNumbers).Split(',',';');
                int[] ArrayOfNumbers = new int[ArrayOfStrings.Length];
                 
                //Расчёт суммы и проверка на отрицательные числа
                for (int i = 0; i < ArrayOfNumbers.Length; i++)
                {
                    ArrayOfNumbers[i] = Int32.Parse(ArrayOfStrings[i]);

                    if (ArrayOfNumbers[i] > 1000)
                        continue;

                    if (ArrayOfNumbers[i] < 0)
                    {
                        list.Add(Convert.ToString(ArrayOfNumbers[i]));
                    }

                    amount += ArrayOfNumbers[i];
                }

                string NegativeString = String.Join(",", list.ToArray());

                    if (list.Count > 0)
                    {
                        throw new NegativeNumberException(NegativeString); 
                    }

                return amount;
            }
        }

        public string TrimString(string StringOfNumbers)
        {
            string pattern1 = @"[^\d-;,]";
            string target = "";
            Regex regex1 = new Regex(pattern1, RegexOptions.Multiline);
            StringOfNumbers = regex1.Replace(StringOfNumbers, target);

            StringOfNumbers = RemoveConsecDuplicates(StringOfNumbers);

            while (!Char.IsDigit(StringOfNumbers[0]))
            {
                StringOfNumbers = StringOfNumbers.Remove(0, 1);
            }

            return StringOfNumbers;
        }
        public static string RemoveConsecDuplicates(string StringOfNumbers) => Regex.Replace(StringOfNumbers, @"(\D)\1+", "$1");
    }
    
}