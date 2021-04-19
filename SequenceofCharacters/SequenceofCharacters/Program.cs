using System;

namespace SequenceofCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSequence = NumOfIndecticalChar(args[0]);
            Console.WriteLine("MAX = " + maxSequence);
        }
        static int NumOfIndecticalChar(string text)
        {
            int counter = 1;
            int maxSequence = 1;
            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] != text[index + 1])
                {
                    counter++;
                    if (counter >= maxSequence)
                    {
                        maxSequence = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            return maxSequence;
        }
    }
}
