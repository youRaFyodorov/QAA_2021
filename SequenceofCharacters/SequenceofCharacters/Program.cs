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
            //string text = "12da1222hfyerudk"; //"sssdeefghrr";
            int counter = 1;
            int maxSequence = 1;
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                j++;
                while (j < text.Length)
                {
                    if (text[i] != text[j])
                    {
                        counter++;
                        if (counter >= maxSequence)
                        {
                            maxSequence = counter;
                        }
                        break;
                    }
                    else
                    {
                        counter = 1;
                        break;
                    }
                }
            }
            return maxSequence;
        }
    }
}
