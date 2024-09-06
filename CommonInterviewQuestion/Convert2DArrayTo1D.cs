using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * convert a two-dimensional array to a one-dimensional array?
     * input: { { 1, 2, 3 }, { 4, 5, 6 } }, output: 1 2 3 4 5 6
     */
    internal class Convert2DArrayTo1D
    {
        public static void Main(string[] args)
        {
            int[,] input = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[] output = ConvertArrayRowWise(input);
            Console.WriteLine("Row wise");
            foreach (int i in output)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            output = ConvertArray(input);
            Console.WriteLine("Alternate Element");
            foreach (int i in output)
            {
                Console.Write(i + " ");
            }
        }

        /* 1 4 2 5 3 6 */
        public static int[] ConvertArray(int[,] array)
        {
            int width = array.GetLength(0);
            int height = array.GetLength(1);

            int[] output = new int[width * height];
            int index = 0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    /* 1 4 2 5 3 6 */
                    output[index++] = array[j, i];
                }
            }
            return output;
        }

        /* 1 2 3 4 5 6 */
        public static int[] ConvertArrayRowWise(int[,] array)
        {
            int width = array.GetLength(0);
            int height = array.GetLength(1);

            int[] output = new int[width * height];
            int index = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    output[index++] = array[i, j];
                }
            }
            return output;
        }
    }
}
