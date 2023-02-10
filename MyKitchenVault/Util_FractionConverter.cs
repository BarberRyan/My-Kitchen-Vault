using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKitchenVault
{
    public static class Util_FractionConverter
    {
        /// <summary>
        /// Converts a decimal to a fraction
        /// </summary>
        /// <param name="value">Decimal to convert</param>
        /// <returns>Converted fraction as a string</returns>
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
                    numerator %= denominator;
                    return wholeNumber + " " + numerator + "/" + denominator;
                }

                return numerator + "/" + denominator;
            }
        }

        /// <summary>
        /// Converts fraction to decimal
        /// </summary>
        /// <param name="fraction">Fraction as a string</param>
        /// <returns>Converted decimal value</returns>
        public static decimal ToDecimal(string fraction)
        {
            try
            {
            if (!fraction.Contains("/"))
            {
                return Convert.ToDecimal(fraction);
            }
            else
            {
                string[] parts = fraction.Split(' ');
                if (parts.Length == 2)
                {
                    string[] fractionParts = parts[1].Split('/');
                    int numerator = Convert.ToInt32(fractionParts[0]);
                    int denominator = Convert.ToInt32(fractionParts[1]);
                    int wholeNumber = Convert.ToInt32(parts[0]);
                    return (decimal)wholeNumber + (decimal)numerator / (decimal)denominator;
                }
                else
                {
                    string[] fractionParts = parts[0].Split('/');
                    int numerator = Convert.ToInt32(fractionParts[0]);
                    int denominator = Convert.ToInt32(fractionParts[1]);
                    return (decimal)numerator / (decimal)denominator;
                }
            }
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Returns the greatest common divisor of two integers
        /// </summary>
        /// <param name="a">First integer to check</param>
        /// <param name="b">Second integer to check</param>
        /// <returns>GCD as an integer</returns>
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
