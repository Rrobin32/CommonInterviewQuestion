using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class RegexCompare
    {
        static void Main(string[] args)
        {
            // Array of regex patterns  
            string[] regexPatterns = new string[]
            {
            @"^[A-Za-z]+$",     // Matches only alphabetic strings (no digits or special characters)
            @"^\d{3}-\d{2}-\d{4}$", // Matches Social Security Number (SSN) format: 123-45-6789
            @"^[a-zA-Z0-9]{5,10}$", // Matches alphanumeric strings of length between 5 and 10 characters
            @"^\w+@\w+\.\w+$"     // Matches email-like strings (simple format)
            };

            string[] regexResults = new string[] {
            @"^XX[\d0-9]{10}",
            @"^XY[\d0-9]{10}",
            @"^DC[\d0-9]{10}",
            @"^ZX[\d0-9]{10}",
            };

            // Ask user to input a string
            //Console.WriteLine("Enter a string to match against regex patterns:");
            string input = "XX1287369027";

            // Use LINQ to check if the input matches any regex pattern
            var matchingPatterns = regexResults.Where(pattern => Regex.IsMatch(input, pattern)).ToArray();

            // Display the results
            if (matchingPatterns.Any())
            {
                Console.WriteLine("The input matches the following patterns:");
                foreach (var pattern in matchingPatterns)
                {
                    Console.WriteLine(pattern);
                }
            }
            else
            {
                Console.WriteLine("The input does not match any patterns.");
            }
        }
    }
}
