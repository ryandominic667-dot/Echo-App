using System;

namespace Practice1
{
    class Practice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            while (true)
            {
                Console.Write("Echo: "); // Changed WriteLine to Write for better prompt
                string input = Console.ReadLine();

                // FIX: Call the ToLower() method using parentheses
                if (input.ToLower() == "exit")
                    break;

                Console.WriteLine("Echo: " + input);
            }

            Console.WriteLine("Goodbye!");
        }
    }
}