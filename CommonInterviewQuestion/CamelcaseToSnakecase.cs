using System.Text;


namespace CommonInterviewQuestion
{
    public class CamelcaseToSnakecase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            string result = Snakecase(str);
            Console.WriteLine(result);
        }

        //LiveKarma
        private static string Snakecase(string? str)
        {
            StringBuilder result = new StringBuilder();
            char[] c = str.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (i == 0)
                {
                    result.Append(Convert.ToString(c[i]).ToLower());
                }
                else
                {
                    if (char.IsUpper(c[i]))
                    {
                        result.Append('_' + c[i].ToString().ToLower());
                    }
                    else
                    {
                        if (c[i] == ' ')
                        {

                        }
                        else
                        {
                            result.Append(c[i]);
                        }

                    }
                }

            }
            return Convert.ToString(result);
        }
    }
}
