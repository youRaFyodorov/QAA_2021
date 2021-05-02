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
                Matrix matrix = new Matrix(size);
                matrix.SquareMatrix();
                matrix.PrintMatrix();

                DiagonalMatrix diagonalMatrix = new DiagonalMatrix(size);
                diagonalMatrix.SquareMatrix();
                Console.WriteLine();
                diagonalMatrix.PrintMatrix();
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
