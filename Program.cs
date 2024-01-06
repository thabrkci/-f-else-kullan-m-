using System.Net.Http.Headers;

namespace Usetheifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the current hour from the system clock
            int time = DateTime.Now.Hour;

            // Using if-else statements to greet the user based on the time of the day
            if (time > 6 && time < 12)
            {
                // If the time is after 6 AM and before 12 PM, it will print "Good morning!"
                Console.WriteLine("Good morning!");
            }
            else if (time <= 18)
            {
                // If the time is 6 AM or later and before 6 PM, it will print "Good day!"
                Console.WriteLine("Good day!");
            }
            else
            {
                // For other times (after 6 PM), it will print "Good night!"
                Console.WriteLine("Good night!");
            }

            // Using the conditional (ternary) operator to achieve the same result as the if-else statements
            string result = time <= 18 ? "Good day!" : "Good night!";
            result = time >= 6 && time < 12 ? "Good morning" : time <= 18 ? "Good day!" : "Good night";
            
            // Printing the final result based on the time
            Console.WriteLine(result);
        }
    }
}
