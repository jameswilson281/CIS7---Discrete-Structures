using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "continue";
            while (input != "q")
            {
                Console.Clear();
                Console.Write("Enter an integer (or 'q' to exit): ");
                input = Console.ReadLine();
                if (input == "q")
                {
                    return;
                }
                if (int.TryParse(input, out int theInteger) == false)
                {
                    Console.WriteLine($"{input} is not a valid integer!");

                }
                else
                {
                    var even = (theInteger % 2 == 0);
                    Console.WriteLine(even ? $"{theInteger} is even" : $"{theInteger} is odd");
                }
                
                Console.ReadLine();
            }
        }
    }
}
