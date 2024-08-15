using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreperation
{
    public class Domination
    {
        public static void Main(string[] args)
        {
            int[] currencyAvailable = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 };
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Enter amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > 0)
            {
                while (amount > 0)
                {
                    for (int i = currencyAvailable.Length - 1; i >= 0; i--)
                    {
                        if (amount >= currencyAvailable[i])
                        {
                            stringBuilder.Append(currencyAvailable[i] + " ");
                            amount = amount - currencyAvailable[i];
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("amount shold be greater than zero.");
            }
            Console.WriteLine(stringBuilder.ToString());
            Console.ReadLine();
        }
    }
}
