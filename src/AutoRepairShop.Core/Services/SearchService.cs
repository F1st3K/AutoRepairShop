using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Core.Services
{
    public class SearchService
    {
        public static int GetLevenshteinDistance(string a, string b)
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a));
            if (b == null)
                throw new ArgumentNullException(nameof(b));

            int lenA = a.Length;
            int lenB = b.Length;
            if (lenA == 0 || lenB == 0)
                return lenA + lenB;

            int[,] matrix = new int[lenA + 1, lenB + 1];
            for (int i = 0; i <= lenA; i++)
                matrix[i, 0] = i;
            for (int j = 0; j <= lenB; j++)
                matrix[0, j] = j;

            for (int j = 1; j <= lenB; j++)
            {
                for (int i = 1; i <= lenA; i++)
                {
                    if (a[i - 1] == b[j - 1])
                        matrix[i, j] = matrix[i - 1, j - 1];
                    else
                        matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1), matrix[i - 1, j - 1] + 1);
                }
            }
            return matrix[lenA, lenB];
        }
    }
}
