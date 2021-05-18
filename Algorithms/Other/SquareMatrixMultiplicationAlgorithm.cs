namespace Algorithms.Other
{
    public static class SquareMatrixMultiplicationAlgorithm
    {
        public static int[,] SquareMatrixMultiplication(int[,] a, int[,] b)
        {
            var n = a.GetLength(0);
            var c = new int[n, n];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    for (var k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;
        }

        public static int[,] SquareMatrixMultiplicationRecursive(int[,] a, int[,] b)
        {
            var n = a.GetLength(0);

            if (n == 1) return new[,] {{a[0, 0] * b[0, 0]}};
            
            var c = new int[n, n];
            var half = n / 2;

            var an = SubMatrix(a, half);
            var bn = SubMatrix(b, half);

            var sm1111 = SquareMatrixMultiplicationRecursive(an.tl, bn.tl);
            var sm1221 = SquareMatrixMultiplicationRecursive(an.tr, bn.bl);
            var sm1112 = SquareMatrixMultiplicationRecursive(an.tl, bn.tr);
            var sm1222 = SquareMatrixMultiplicationRecursive(an.tr, bn.br);
            var sm2111 = SquareMatrixMultiplicationRecursive(an.bl, bn.tl);
            var sm2221 = SquareMatrixMultiplicationRecursive(an.br, bn.bl);
            var sm2112 = SquareMatrixMultiplicationRecursive(an.bl, bn.tr);
            var sm2222 = SquareMatrixMultiplicationRecursive(an.br, bn.br);

            for (var i = 0; i < half; i++)
            {
                for (var j = 0; j < half; j++)
                {
                    c[i, j] = sm1111[i, j] + sm1221[i, j];
                    c[i, j + half] = sm1112[i, j] + sm1222[i, j];
                    c[i + half, j] = sm2111[i, j] + sm2221[i, j];
                    c[i + half, j + half] = sm2112[i, j] + sm2222[i, j];
                }
            }

            return c;
        }

        private static (int[,] tl, int[,] tr, int[,] bl, int[,] br) SubMatrix(int[,] a, int half)
        {
            var tl = new int[half, half];
            var tr = new int[half, half];
            var bl = new int[half, half];
            var br = new int[half, half];
            
            for (var i = 0; i < half; i++)
            {
                for (var j = 0; j < half; j++)
                {
                    tl[i, j] = a[i, j];
                    tr[i, j] = a[i, j + half];
                    bl[i, j] = a[i + half, j];
                    br[i, j] = a[i + half, j + half];
                }
            }

            return (tl, tr, bl, br);
        }
    }
}