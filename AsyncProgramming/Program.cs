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
            int count = 200000;
            char charToConcatenate = '1';

            //Task t = new Task(ConcatenateChars);
            Task t = Task.Factory.StartNew(() => ConcatenateChars(charToConcatenate, count)); 


            Console.WriteLine("In Progress"); // You want this line to execute at the same time our method executes. 
            t.Wait(); // We are telling our task to wait until completion before proceeding. 
            Console.WriteLine("Completed");
        }

        // Lets create a method that concatenates a really long string
        public static void ConcatenateChars(char charToConcatenate, int count)
        {
            string concatenatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                concatenatedString += charToConcatenate;
            }
        }
    }
}
