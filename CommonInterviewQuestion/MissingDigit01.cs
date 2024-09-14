using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class MissingDigit01
    {
        public static void Main(string[] args)
        {
            string inputExpression = "6 * 100 = 6x0";
            string missingDigit = FindMissingDigit(inputExpression);
            Console.WriteLine(missingDigit);
        }

        public static string FindMissingDigit(string expression)
        {
            string[] expArr = expression.Split(' ');
            string firstOperand = expArr[0];
            string secondOperand = expArr[2];
            string @operator = expArr[1];
            string result = expArr[4];

            int res = 0;
            string missingValue = string.Empty;

            if (firstOperand.Contains("x"))
            {
                int second = int.Parse(secondOperand);
                int _result = int.Parse(result);

                switch (@operator)
                {
                    case ("+"):
                        res = _result - second;
                        break;

                    case ("-"):
                        res = _result + second;
                        break;

                    case ("*"):
                        res = _result / second;
                        break;

                    default:
                        res = _result * second;
                        break;

                }
                if (res > 0)
                {
                    string[] first = firstOperand.Split("x");
                    if (first.Length == 2 && !string.IsNullOrEmpty(first[1]) && !string.IsNullOrEmpty(first[0]))
                    {
                        int beforeX = first[0].Length;
                        int afterX = first[1].Length;
                        missingValue = res.ToString().Substring(beforeX + 1, afterX);
                        
                    }
                    else if (firstOperand.ToCharArray()[0] == 'x')
                    {
                        missingValue = res.ToString().Substring(0, res.ToString().Length - first[1].Length);
                    }
                    else
                    {
                        int beforeX = first[0].Length;
                        missingValue = res.ToString().Substring(beforeX, res.ToString().Length-1); 
                    }
                }
                else
                {
                    res = 0;
                }
            }

            else if (secondOperand.Contains("x"))
            {
                int first = int.Parse(firstOperand);
                int _result = int.Parse(result);

                switch (@operator)
                {
                    case ("+"):
                        res = _result - first;
                        break;

                    case ("-"):
                        res = first - _result;
                        break;

                    case ("*"):
                        res = _result / first;
                        break;

                    default:
                        res = first / _result;
                        break;

                }

                if (res > 0)
                {
                    string[] second = secondOperand.Split("x");
                    if (second.Length == 2 && !string.IsNullOrEmpty(second[1]) && !string.IsNullOrEmpty(second[0]))
                    {
                        int beforeX = second[0].Length;
                        int afterX = second[1].Length;
                        missingValue = res.ToString().Substring(beforeX + 1, afterX);

                    }
                    else if (secondOperand.ToCharArray()[0] == 'x')
                    {
                        missingValue = res.ToString().Substring(0, res.ToString().Length - second[1].Length);
                    }
                    else
                    {
                        int beforeX = second[0].Length;
                        missingValue = res.ToString().Substring(beforeX, res.ToString().Length - 1);
                    }
                }
                else
                {
                    res = 0;
                }
            }
            else
            {
                int first = int.Parse(firstOperand);
                int second = int.Parse(secondOperand);

                switch (@operator)
                {
                    case ("+"):
                        res = first + second;
                        break;

                    case ("-"):
                        res = first - second;
                        break;

                    case ("*"):
                        res = first * second;
                        break;

                    default:
                        res = first / second;
                        break;

                }

                if (res > 0)
                {
                    string[] resultant = result.Split("x");
                    if (resultant.Length == 2 && !string.IsNullOrEmpty(resultant[1]) && !string.IsNullOrEmpty(resultant[0]))
                    {
                        int beforeX = resultant[0].Length;
                        int afterX = resultant[1].Length;
                        missingValue = res.ToString().Substring(beforeX + 1, afterX);

                    }
                    else if (result.ToCharArray()[0] == 'x')
                    {
                        missingValue = res.ToString().Substring(0, res.ToString().Length - resultant[1].Length);
                    }
                    else
                    {
                        int beforeX = resultant[0].Length;
                        missingValue = res.ToString().Substring(beforeX, res.ToString().Length - 1);
                    }
                }
                else
                {
                    res = 0;
                }
            }
            return missingValue;
        }
    }
}
