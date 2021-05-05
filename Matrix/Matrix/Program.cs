using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int size = 5;
                Matrix<int> matrix = new Matrix<int>(size);
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = rnd.Next(0, 100) ;
                    }
                }

                Console.WriteLine(matrix.ToString());
                DiagonalMatrix<int> diagonalMatrix = new DiagonalMatrix<int>(size);
                for (int i = 0; i < size; i++)
                {
                    diagonalMatrix[i, i] = rnd.Next(0, 10);
                }
                Console.WriteLine(diagonalMatrix.ToString());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
