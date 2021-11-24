using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConNumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int startingNumber = 5;
            int numberOfSums = 3;
            int outputLength = 20;

            
            int[] output = new int[outputLength];
            output[0] = startingNumber;

            for(int i=1; i<numberOfSums; i++)
            {
                output[i]= output.Sum();
            }

            for(int i = numberOfSums; i < outputLength; i++)
            {
                int sum = 0;
                for(int j = 0; j < numberOfSums; j++){
                    sum += output[i - j - 1];
                }
                output[i] = sum;
            }


            //OUTPUT///////////////////////////////////////////////////////////////////////////////////
            for(int i=0; i < outputLength; i++)
            {
                Console.Write(output[i]);
                if (i == outputLength - 1)
                {
                    Console.Write("\n");
                }
                else { Console.Write(", "); }
            }

            for (int i = 0; i < outputLength; i++)
            {
                Console.Write(output[outputLength - 1 - i]);
                if (i == outputLength - 1)
                {
                    Console.Write("\n");
                }
                else { Console.Write(", "); }
            }

            Console.ReadLine();
        }
    }
}
