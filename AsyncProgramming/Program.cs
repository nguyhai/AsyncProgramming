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
            Task<string> t = ConcatenateChars(charToConcatenate, count);


            Console.WriteLine("In Progress"); // You want this line to execute at the same time our method executes. 
            //t.Wait(); // We are telling our task to wait until completion before proceeding. No longer need this if we use Async/Await
            
            Console.WriteLine("The length of the result is " + t.Result.Length);

        }

        // Lets create a method that concatenates a really long string
        public async static Task<string> ConcatenateChars(char charToConcatenate, int count) // Now using async keyword
        {
            Task<string> t = Task<string>.Factory.StartNew(()=> 
            {
                string concatenatedString = string.Empty;

                for (int i = 0; i < count; i++)
                {
                    concatenatedString += charToConcatenate;
                }
                return concatenatedString;
            });

            // using the await keyword for return. For this example, we are only waiting for the return
            // Since we have the await keyword here, the above Task is executing asynchronously. It is just waiting fro "t" to complete. 
            string result = await t;

            Console.WriteLine("Completed");
            return result; 
        }
    }
}
