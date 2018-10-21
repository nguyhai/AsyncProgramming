using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcatenateChars();
            Console.WriteLine("Completed");
        }

        // Lets create a method that concatenates a really long string
        public static void ConcatenateChars()
        {
            string concatenatedString = string.Empty;

            for (int i = 0; i < 200000; i++)
            {
                concatenatedString += 1;
            }
        }
    }
}
