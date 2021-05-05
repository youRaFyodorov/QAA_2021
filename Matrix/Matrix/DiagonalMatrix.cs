using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class DiagonalMatrix<T> : Matrix<T>
    {
        public override T this[int index, int jndex]
        {
            get
            {
                if (index == jndex)
                {
                    return array[index];
                }
                else return default(T);
            }
            set
            {
                if (index == jndex)
                {
                    array[index] = value;
                }
            }
        }
        public DiagonalMatrix(int size) : base(size)
        {
            SizeOfMatrix = size;
            array = new T[size];
        }
    }
}
