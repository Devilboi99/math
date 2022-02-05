using System;
using System.IO;

namespace superMath
{
    public class Combinatorics
    {
        public static double Permutation(string line, int index)
        {
            if (line.Length <= index)
                return 1;
            var countSameSymbol = FindSameSymbol(line, index);
            return Permutation(line, ++index) * index / countSameSymbol;
        }

        private static int FindSameSymbol(string line, int index)
        {
            var sameSymbol = 1;
            for (var j = 0; j < index; ++j)
                if (line[index] == line[j])
                    ++sameSymbol;
            return sameSymbol;
        }
    }

    public class BaseMath
    {
        public static double BinomNtutona(int a, int b, int pow)
        {
            var total = 0.0;
            for (var j = 0; j <= pow; ++j)
                total += Ftl(pow) / (Ftl(pow - j) * Ftl(j)) * Math.Pow(a, pow - j) * Math.Pow(b, j);

            return total;
        }

        public static int Ftl(int x)
        {
            var answer = 1;

            if (x == 0)
                x = 1;

            for (var j = 1; j <= x; j++)
                answer *= j;

            return answer;
        }
    }
}