using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixHasYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = Matrix.RandMatrix(2,2);
            Matrix matrix2 = Matrix.RandMatrix(2,2);

            matrix.PrintMatrix();
            matrix2.PrintMatrix();

            Console.WriteLine("Сумма матриц:");
            Matrix matrix3 = matrix + matrix2;
            matrix3.PrintMatrix();

            Console.WriteLine("Вычитание матриц:");
            matrix3 = matrix - matrix2;
            matrix3.PrintMatrix();

            Console.WriteLine("Умножение матрицы на число слева:");
            matrix3 = matrix * 2;
            matrix3.PrintMatrix();

            Console.WriteLine("Умножение матрицы на число справа:");
            matrix3 = 2 * matrix;
            matrix3.PrintMatrix();

            Console.WriteLine("Умножение матриц:");
            matrix3 = matrix * matrix2;
            matrix3.PrintMatrix();

            Console.ReadLine();
        }
    }
}
