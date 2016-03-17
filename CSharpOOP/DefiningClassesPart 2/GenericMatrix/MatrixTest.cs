using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    class MatrixTest
    {
        public static void Run()
        {
            var firstMatrix = new Matrix<int>(2, 2);
            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 2;
            firstMatrix[1, 0] = 3;
            firstMatrix[1, 1] = 4;

            var secondMatrix = new Matrix<int>(2, 2);

            secondMatrix[0, 0] = 5;
            secondMatrix[0, 1] = 6;
            secondMatrix[1, 0] = 7;
            secondMatrix[1, 1] = 8;

            Console.WriteLine("First matrix: ");
            Console.WriteLine(firstMatrix.ToString());
            Console.WriteLine("Second matrix: ");
            Console.WriteLine(secondMatrix.ToString());

            Console.WriteLine("First matrix + Second matrix: ");
            Console.WriteLine((firstMatrix + secondMatrix).ToString());

            Console.WriteLine("First matrix - Second matrix: ");
            Console.WriteLine((firstMatrix - secondMatrix).ToString());

            Console.WriteLine("First matrix * Second matrix: ");
            Console.WriteLine((firstMatrix * secondMatrix).ToString());

            Console.WriteLine("The value at position [1, 0] in the first matrix is {0}", firstMatrix[1,0]);
            Console.WriteLine();
            Console.WriteLine("The matrixes have {0} rows and {1} columns", firstMatrix.Rows, firstMatrix.Columns);
            Console.WriteLine();

            var zeroMatrix = new Matrix<int>(1, 1);
            secondMatrix[0, 0] = 0;
            secondMatrix[0, 1] = 0;

            Console.WriteLine(firstMatrix ? "First matrix is a zero matrix" : "First matrix is a non-zero matrix");
            Console.WriteLine(zeroMatrix ? "Zero matrix is a zero matrix" : "Zero matrix is a non-zero matrix");
            Console.WriteLine();
        }
    }
}
