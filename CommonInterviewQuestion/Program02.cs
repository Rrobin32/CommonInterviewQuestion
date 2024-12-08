using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program02
    {
        public static void Main(string[] args)
        {
            int[] array = { 4, 5, 6, 1, 2, 3 };

            int[] ascArray = SortAscending(array);
            int[] descArray = SortDescending(array);

            foreach (int i in ascArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            foreach (int i in descArray)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] SortAscending(int[] array)
        {
            int temp = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public static int[] SortDescending(int[] array)
        {
            int temp = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for(int j = i + 1;j <= array.Length - 1; j++)
                {
                    if(array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
