using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class MissingDigit
    {
        public static void Main(string[] args)
        {
            string inputExpression = "100 * x = 500";
            int missingDigit = FindMissingDigit(inputExpression);
            Console.WriteLine(missingDigit);
        }

        public static int FindMissingDigit(string expression)
        {
            string[] expArr = expression.Split(' ');
            string firstOperand = expArr[0];
            string secondOperand = expArr[2];
            string @operator = expArr[1];
            string result = expArr[4];

            int res = 0;
            if (firstOperand.Equals("x"))
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
            }

            else if (secondOperand.Equals("x"))
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
                        res =  _result / first;
                        break;

                    default:
                        res = first / _result;
                        break;

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
            }

            return res;
        }
    }


}
