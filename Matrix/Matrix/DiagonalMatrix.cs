using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class DiagonalMatrix: Matrix
    {
        public override int this[int index, int jndex]
        {
            get
            {
                if (index == jndex)
                {
                    return array[index];
                }
                else return 0;
            }
            set
            {
                if (index == jndex)
                {
                    array[index] = value;   
                }
            }
        }
        public DiagonalMatrix (int size): base (size)
        {
            array = new int[size];
        }
    }
}
