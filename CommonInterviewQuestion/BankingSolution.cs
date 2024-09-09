using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class BankingSolution
    {
        public static void Main(string[] args)
        {
            string[][] array = [
                                 ["CREATE_ACCOUNT", "1", "account1"],
                                 ["CREATE_ACCOUNT", "2", "account1"],
                                 ["CREATE_ACCOUNT", "3", "account2"],
                                 ["DEPOSIT", "4", "non-existing", "2700"],
                                 ["DEPOSIT", "5", "account1", "2700"],
                                 ["PAY", "6", "non-existing", "2700"],
                                 ["PAY", "7", "account1", "2701"],
                                 ["PAY", "8", "account1", "200"],
                                 ["PAY", "9", "account1", "200"],
                                 ["DEPOSIT", "10", "account2", "300"],
                               ];

            //BankingSolution bankingSolution = new BankingSolution();
            //string[] result = bankingSolution.solution(array);
            string[] result = solution(array);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string[] solution(string[][] queries)
        {
            int row = queries.Length;
            string[] result = new string[queries.Length];
            Dictionary<string, int> accounts = new Dictionary<string, int>();

            for (int i = 0; i < row; i++)
            {
                switch (queries[i][0])
                {
                    case "CREATE_ACCOUNT":
                        if (accounts.ContainsKey(queries[i][2]))
                        {
                            result[i] = "false";
                        }
                        else
                        {
                            accounts.Add(queries[i][2], 0);
                            result[i] = "true";
                        }
                        break;

                    case "DEPOSIT":
                        if (accounts.ContainsKey(queries[i][2]))
                        {
                            accounts[queries[i][2]] += Convert.ToInt32(queries[i][3]);
                            result[i] = Convert.ToString(accounts[queries[i][2]]);
                        }
                        else
                        {
                            result[i] = @"""""";
                        }
                        break;

                    case "PAY":
                        if (accounts.ContainsKey(queries[i][2]))
                        {
                            var availableBalance = accounts[queries[i][2]];
                            if (availableBalance >= Convert.ToInt32(queries[i][3]))
                            {
                                accounts[queries[i][2]] = availableBalance - Convert.ToInt32(queries[i][3]);
                                result[i] = Convert.ToString(accounts[queries[i][2]]);
                            }
                            else
                            {
                                result[i] = @"""""";
                            }
                        }
                        else
                        {
                            result[i] = @"""""";
                        }
                        break;
                }
            }
            return result;
        }
    }
}
