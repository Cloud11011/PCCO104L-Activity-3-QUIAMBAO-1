using System;

class Program
{
    static void Main(string[] args)
    {
        string inputstring = "String of words: ";
        int sumofintegers = 0;

        while (true)
        {
            Console.Write("Enter a string or an integer(Enter 'exit' to exit program): ");
            string userInput = Console.ReadLine();

            if (userInput == "exit")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }

            if (int.TryParse(userInput, out int number))
            {
                sumofintegers += number;
                Console.WriteLine("Sum of integers: " + sumofintegers);
            }
            else
            {
               inputstring += userInput;
               Console.WriteLine(inputstring); 
            }



        }
    }
}