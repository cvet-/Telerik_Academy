using System;
using System.Text;

namespace GenericMatrix
{
    class Matrix<T>
    {
        private readonly T[,] matrix;
        private int cols;
        private int rows;

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Columns = cols;
            matrix = new T[Rows, Columns];
        }

        public int Rows
        {
            get { return rows; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(null, "The matrix rows count cannot be a negative number.");
                }

                rows = value;
            }
        }

        public int Columns
        {
            get { return cols; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(null, "The matrix columns count cannot be a negative number.");
                }

                cols = value;
            }
        }
        /// <summary>
        /// Implement the operator +
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Matrix<T> operator +
            (Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> result = new Matrix<T>(first.Rows, first.Columns);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] + second[row, col];
                }
            }
            return result;
        }
        /// <summary>
        /// Implement the operator -
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Matrix<T> operator -
            (Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> result = new Matrix<T>(first.Rows, first.Columns);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] - second[row, col];
                }
            }
            return result;
        }
        /// <summary>
        /// Implement the operator *
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Matrix<T> operator *
            (Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> result = new Matrix<T>(first.Rows, first.Columns);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] * second[row, col];
                }
            }
            return result;
        }
        // Indexer to access the inner matrix cells
        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= matrix.GetLength(0))
                {
                    throw new ArgumentOutOfRangeException("row", "The row value is out of the range of possible row values.");
                }

                if (col < 0 || col >= matrix.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException("col", "The col value is out of the range of possible row values.");
                }

                return matrix[row, col];
            }
            set { matrix[row, col] = value; }
        }
        // Check for non-zero elements
        public static bool operator true(Matrix<T> matrix)
        {
            return IsZeroMatrix(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return !IsZeroMatrix(matrix);
        }

        private static bool IsZeroMatrix(Matrix<T> matrix)
        {
            if (matrix.Rows == 0 || matrix.Columns == 0)
            {
                return true;
            }

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            string result = null;
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Columns; col++)
                {
                    result += matrix[row, col] + " ";
                }
                result += Environment.NewLine;
            }
            return result;
        }

    }
}