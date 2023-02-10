using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchenVault
{
    internal class StarHandler
    {
        /// <summary>
        /// Converts decimal rating into an array of index numbers to display and take ratings
        /// </summary>
        /// <param name="rating">Rating as a decimal between 0 and 5</param>
        /// <returns>Array of index numbers, each element represents one star</returns>
        public static int[] SetStars(decimal rating)
        {
            int[] output = new int[5];
            switch (rating)
            {
                case decimal r when (r < 0.25M):
                    output = new int[] { 0, 0, 0, 0, 0 };
                    break;
                case decimal r when (r >= 0.25M && r <= 0.5M):
                    output = new int[] { 1, 0, 0, 0, 0 };
                    break;

                case decimal r when (r > 0.5M && r < 1.25M):
                    output = new int[] { 2, 0, 0, 0, 0 };
                    break;

                case decimal r when (r >= 1.25M && r <= 1.5M):
                    output = new int[] { 2, 1, 0, 0, 0 };
                    break;

                case decimal r when (r > 1.5M && r < 2.25M):
                    output = new int[] { 2, 2, 0, 0, 0 };
                    break;

                case decimal r when (r >= 2.25M && r <= 2.5M):
                    output = new int[] { 2, 2, 1, 0, 0 };
                    break;

                case decimal r when (r > 2.5M && r < 3.25M):
                    output = new int[] { 2, 2, 2, 0, 0 };
                    break;

                case decimal r when (r >= 3.25M && r <= 3.5M):
                    output = new int[] { 2, 2, 2, 1, 0 };
                    break;

                case decimal r when (r > 3.5M && r < 4.25M):
                    output = new int[] { 2, 2, 2, 2, 0 };
                    break;

                case decimal r when (r >= 4.25M && r <= 4.5M):
                    output = new int[] { 2, 2, 2, 2, 1 };
                    break;

                case decimal r when (r > 4.5M && r <= 5.0M):
                    output = new int[] { 2, 2, 2, 2, 2 };
                    break;
            }
            return output;
        }
    }
}
