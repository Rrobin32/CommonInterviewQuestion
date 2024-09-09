using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    public class TraverseArray
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1 };
            int[] arrayLeft = new int[] { };
            int[] arrayRight = new int[] { };
            int position = 0, positiveIndexes = 0, rightCounter = 0, leftCounter = 0;
            Console.Write("enter position: ");
            position = Convert.ToInt32(Console.ReadLine());
            TraverseArray traverseArray = new TraverseArray();
            if (position == 0)
            {
                if (position == 0 && array[position + 1] > 0 && array[position] > 0)
                {
                    traverseArray.Split(array, position, out arrayLeft, out arrayRight);
                    positiveIndexes = Array.IndexOf(arrayRight, 0);
                }
                else if (position == 0 && array[position + 1] > 0)
                {
                    traverseArray.Split(array, position + 1, out arrayLeft, out arrayRight);
                    positiveIndexes = Array.IndexOf(arrayRight, 0);
                }
                else
                {
                    positiveIndexes = 0;
                }
            }
            else
            {
                #region Approch 1
                //if (array[position - 1] > 0 && array[position + 1] > 0 && array[position] > 0)
                //{
                //    traverseArray.Split(array, position, out arrayLeft, out arrayRight);
                //    int positiveValueIndexRight = Array.IndexOf(arrayRight, 0);

                //    int positiveValueIndexLeft = arrayLeft.Length - (Array.LastIndexOf(arrayLeft, 0) + 1);

                //    positiveIndexes = positiveValueIndexLeft + positiveValueIndexRight;
                //}

                //else if(array[position - 1] > 0 && array[position + 1] > 0 && array[position] == 0)
                //{
                //    traverseArray.Split(array, position + 1, out arrayLeft, out arrayRight);
                //    int positiveValueIndexRight = Array.IndexOf(arrayRight, 0);

                //    var arrayLeftList = arrayLeft.ToList();
                //    arrayLeftList.RemoveAt(arrayLeft.Length-1);
                //    arrayLeft = arrayLeftList.ToArray();

                //    int positiveValueIndexLeft = arrayLeft.Length - (Array.LastIndexOf(arrayLeft, 0) + 1);

                //    positiveIndexes = positiveValueIndexLeft > positiveValueIndexRight ? positiveValueIndexLeft : positiveValueIndexRight;
                //}
                //else if(array[position - 1] == 0 && array[position + 1] > 0 && array[position] == 0)
                //{

                //}
                //else if (array[position - 1] == 0 && array[position + 1] > 0 && array[position] == 1)
                //{

                //}
                //else if (array[position - 1] > 0 && array[position + 1] == 0 && array[position] == 0)
                //{

                //}
                //else
                //{

                //}
                #endregion Approch 1
            }
        }


        public void Split<T>(T[] array, int index, out T[] first, out T[] second)
        {
            first = array.Take(index).ToArray();
            second = array.Skip(index).ToArray();
        }
    }
}
