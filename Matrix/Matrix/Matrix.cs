using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Matrix
    {
        public int SizeOfMatrix { get; }
        public int [] array;
        
        public Matrix (int size)
        {   
            SizeOfMatrix = size;
            array = new int[size * size];
            for (int i = 0; i < size*size; i++)
            {
                array[i] = 0;
            }
        } 
        public virtual int this[int index, int jndex]
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
        public void SquareMatrix()
        {
           for (int i = 0; i < SizeOfMatrix; i++)
           {
                for (int j = 0; j < SizeOfMatrix; j++)
                {
                    this[i, j] = j + 5;
                }
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
    }

}


    