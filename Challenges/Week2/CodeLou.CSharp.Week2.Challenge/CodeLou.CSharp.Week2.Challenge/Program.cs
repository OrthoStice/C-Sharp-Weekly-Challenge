using System;
namespace CodeLou.CSharp.Week2.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Code Louisville C# week 2 code challenge!");
            Console.WriteLine("Press <Enter> to begin...");
            Console.ReadLine();
            Console.WriteLine("This is the launch application for the first human mission to Mars.");
            Console.Write("Enter the number of seconds you would like to count down from: ");
            var countDownEntry = Console.ReadLine();
            // Task 4:
            // Write a condition to test whether the number that they entered is less than or equal to zero.
            // Call the IsLessThanOrEqualToZero() method below, passing the user's number as a parameter.
            // If the result is true, write "Please enter a positive number." to the console.
            // Hint: The input that you captured is currently a string type. You will have to "parse" it
            //       as a different type in order to pass it to the IsLessThanOrEqualToZero function.
            public IsLessThanOrEqualToZero(countDownEntry) { }
           
            // Task 5:
            // Add an "else" block to the condition from Task 4. This should be run in the case that the
            // number is greater than zero. Write each number to the console, counting backwards, from the 
            // user's number to zero. Then write, "LIFTOFF!".
            // Hint: You can accomplish this with one of several kinds of loops, including "while" and
            //       "for". You can choose whichever you'd like to solve the task. The Microsoft
            //       Developer Network (MSDN) website contains all of the documentation for C#. If you want
            //       to learn more about loops, visit https://msdn.microsoft.com/en-us/library/32dbftby.aspx.

        Console.WriteLine("Press <Enter> to exit...");
            Console.ReadLine();
        }

        static bool IsLessThanOrEqualToZero(int num)
        {
            return num <= 0;
        }
    }
}