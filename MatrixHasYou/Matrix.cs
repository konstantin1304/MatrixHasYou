using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixHasYou
{
    class Matrix
    {
        public int m { get { return A.GetLength(0); } }
        public int n { get { return A.GetLength(1); } }
        public double[,] A { get; private set; }

        public Matrix(double[,] A)
        {
            this.A = A;
        }
        
        public void PrintMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{A[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static Matrix RandMatrix(int m, int n, int min = 0, int max = 10)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            double[,] A = new double[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rnd.Next(min, max);
                }
            }
            Matrix matrix = new Matrix(A);

            return matrix;
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            if ((A.n != B.n) || (A.m != B.m))
            {
                return null;
            }
            double[,] D  = new double [A.n,A.m];

            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    D[i, j] = A.A[i, j] + B.A[i, j];
                }
            }
            Matrix M = new Matrix(D);

            return M;
        }
        public static Matrix operator -(Matrix A, Matrix B)
        {
            if ((A.n != B.n) || (A.m != B.m))
            {
                return null;
            }
            double[,] D = new double [A.n, A.m];
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    D[i, j] = A.A[i, j] - B.A[i, j];
                }
            }
            Matrix M = new Matrix(D);

            return M;
        }
        public static Matrix operator *(Matrix A, double L)
        {
            double[,] D = new double[A.n, A.m];
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    D[i, j] = A.A[i, j] * L;
                }
            }
            Matrix M = new Matrix(D);

            return M;
        }
        public static Matrix operator *(double L, Matrix A)
        {
            double[,] D = new double[A.n, A.m];
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    D[i, j] = A.A[i, j] * L;
                }
            }
            Matrix M = new Matrix(D);

            return M;
        }
        public static Matrix operator *(Matrix A, Matrix B)
        {
            double[,] D = new double[A.n, B.m];
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < B.m; j++)
                {
                    for (int k = 0; k < B.n; k++)
                    {
                        D[i, j] += A.A[i, k] * B.A[k, j];
                    }
                   
                }
            }
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < b.GetLength(0); k++)
            //        {
            //            r[i, j] += a[i, k] * b[k, j];
            //        }
            //    }
            //}
            //return r;
            Matrix M = new Matrix(D);

            return M;
        }

    }

}
