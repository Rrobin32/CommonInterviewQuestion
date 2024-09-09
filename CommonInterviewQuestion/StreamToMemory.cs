using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class StreamToMemory
    {
        public static void Main()
        {
            // Example string to simulate StreamReader input
            string exampleText = "This is an example text.";
            byte[] byteArray = Encoding.UTF8.GetBytes(exampleText);

            // Create a MemoryStream from the byte array
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                // Create a StreamReader to read from the MemoryStream
                using (StreamReader reader = new StreamReader(memoryStream))
                {
                    // Read the content from the StreamReader
                    string content = reader.ReadToEnd();

                    // Convert the content to a byte array
                    byte[] contentBytes = Encoding.UTF8.GetBytes(content);

                    // Write the byte array to a new MemoryStream
                    using (MemoryStream outputMemoryStream = new MemoryStream(contentBytes))
                    {
                        // Use the outputMemoryStream as needed
                        Console.WriteLine("MemoryStream created successfully.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
