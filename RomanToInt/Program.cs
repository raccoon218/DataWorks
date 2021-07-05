using System;
using System.Text;

namespace RomanToInt
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("mmcmxcix"));
        }

        public static int RomanToInt(string s)
        {
            string[] Thousands = { "MM", "M" };
            string[] Hundreds = { "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C" };
            string[] Tens = { "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X" };
            string[] Units = { "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };

            int value = 0;
            if (string.IsNullOrEmpty(s)) Console.WriteLine("введите не пустое римское число исплользуя символы I V X L C D M");
            s = s.ToUpper();
            int len = 0;

            for (int i = 0; i < 2; i++)
            {
                if (s.StartsWith(Thousands[i]))
                {
                    value += 1000 * (2 - i);
                    len = Thousands[i].Length;
                    break;
                }
            }

            if (len > 0)
            {
                s = s.Substring(len);
                len = 0;
            }

            for (int i = 0; i < 9; i++)
            {
                if (s.StartsWith(Hundreds[i]))
                {
                    value += 100 * (9 - i);
                    len = Hundreds[i].Length;
                    break;
                }
            }

            if (len > 0)
            {
                s = s.Substring(len);
                len = 0;
            }

            for (int i = 0; i < 9; i++)
            {
                if (s.StartsWith(Tens[i]))
                {
                    value += 10 * (9 - i);
                    len = Tens[i].Length;
                    break;
                }
            }

            if (len > 0)
            {
                s = s.Substring(len);
                len = 0;
            }

            for (int i = 0; i < 9; i++)
            {
                if (s.StartsWith(Units[i]))
                {
                    value += 9 - i;
                    len = Units[i].Length;
                    break;
                }
            }

            if (s.Length > len)
            {
                value = 0;
                Console.WriteLine("введите число");
            }

            return value;
        }
    }
}
