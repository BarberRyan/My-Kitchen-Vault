using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchenVault
{
    public static class FractionUtil
    {
        public static string ToFraction(this decimal value)
        {
            if (value % 1 == 0)
            {
                return ((int)value).ToString();
            }
            else
            {
                int numerator = (int)(value * (decimal)Math.Pow(10, value.ToString().Split('.')[1].Length));
                int denominator = (int)Math.Pow(10, value.ToString().Split('.')[1].Length);

                int gcd = CalculateGCD(numerator, denominator);
                numerator /= gcd;
                denominator /= gcd;

                if (numerator > denominator)
                {
                    int wholeNumber = numerator / denominator;
                    numerator = numerator % denominator;
                    return wholeNumber + " " + numerator + "/" + denominator;
                }

                return numerator + "/" + denominator;
            }
        }
        private static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
