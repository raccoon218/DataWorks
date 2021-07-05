using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckParenthesisBalance
{
    /*
     Проверить сбалансированность скобочной структуры в произвольном выражении ((1+3)()(4+(3-5)))
     */

    public class Program
    {
        static string line = "((1+3)()(4+(3-5)))";
        static char open = '(';
        static char close = ')';

        static void Main(string[] args)
        {
            Console.WriteLine(CheckParenthesisBalance());
        }

        public static string CheckParenthesisBalance() 
        {
            if (Ingridients(open) > Ingridients(close))
            {
                return $"Больше открывающих '{open}' скобок";
            }
            else if (Ingridients(open) < Ingridients(close))
            {
                return $"Больше закрывающих '{close}' скобок ";
            }
            else return "Скобки в балансе";
        }

        public static int Ingridients(char c)
        {
            return line.Count(l => l.Equals(c));
        }
    }
}
