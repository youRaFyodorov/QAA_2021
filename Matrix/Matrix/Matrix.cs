using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Matrix<T>
    {
        public int SizeOfMatrix { get; set; }
        public T[] array;

        public Matrix(int size)
        {
            SizeOfMatrix = size;
            int lengthOfMassive = SizeOfMatrix * SizeOfMatrix;
            array = new T[lengthOfMassive];
        }
        public virtual T this[int index, int jndex]
        {
            get
            {
                return array[index * SizeOfMatrix + jndex];
            }
            set
            {
                array[index * SizeOfMatrix + jndex] = value;
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < SizeOfMatrix; i++)
            {
                for (int j = 0; j < SizeOfMatrix; j++)
                {
                    Console.Write(this[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        public override string ToString()
        {
            StringBuilder matrixString = new StringBuilder();
            for (int i = 0; i < SizeOfMatrix; i++)
            {
                for (int j = 0; j < SizeOfMatrix; j++)
                {
                    matrixString.Append(this[i, j]);
                    matrixString.Append(" ");
                }
                matrixString.Append("\n");
            }
            return matrixString.ToString();
        }
    }

}


    