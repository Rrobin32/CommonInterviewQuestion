using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreperation
{
    public class PowerOf2
    {
        public static void Main(string[] args)
        {
            Console.Write("Define the size of the array: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Enter array[" + i + "] : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            string enteredArray = "[";
            foreach (var item in array)
            {
                enteredArray = enteredArray + item.ToString() + ",";
            }
            enteredArray = enteredArray.Remove(enteredArray.Length - 1) + "]";
            Console.WriteLine("Entered Array : " + enteredArray);
            var result = PowerOf2Calculation(array.ToList());
            Console.ReadLine();
        }

        static List<int> PowerOf2Calculation(List<int> arr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                while (arr[i] % 2 == 0)
                {
                    result.Insert(i+1, 1);
                }
                result.Insert(i, 0);
            }
            return result;
        }
    }


}
