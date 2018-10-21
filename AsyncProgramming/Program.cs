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
            //Task t = new Task(ConcatenateChars);
            Task t = Task.Factory.StartNew(ConcatenateChars); // Easier way to do this

            t.Start(); // Starts the method, runs async to our other code. At the same time, it runs our writeline code. The main thread is the high priority, not the method.



            Console.WriteLine("In Progress"); // You want this line to execute at the same time our method executes. 






            t.Wait(); // We are telling our task to wait until completion before proceeding. 
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
