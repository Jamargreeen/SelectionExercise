using System;

namespace SelectionStatementAndSwitchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my numbers guessing game!");
            Console.WriteLine("I want you to guess my favorite number");
            Console.WriteLine("What is the upper limit for the range of the number");

            var userResponse = Console.ReadLine();

        var upperLimit = int.Parse(userResponse);

        var random = new Random();
        var number = random.Next(1, upperLimit);

        Console.WriteLine("Take your best guess:");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your guess is too high, oh no!");
            }
            else if (guess<number)
            {
                Console.WriteLine("Your guess is too low, oh no!");
            }
            else
{
    Console.WriteLine("You got it right!");
}
        }
        static void Master(string[] args)
{
    Console.WriteLine("What is your favorite subject in school?");

    var subject = Console.ReadLine(); //evaluate to a string

    switch (subject)
    {
        case "Science":
            Console.WriteLine("Science is not cool");
            break;
        case "English":
            Console.WriteLine("English is ok but not my favorite");
            break;
        case "Math":
            Console.WriteLine("I like math!!");
            break;
        default:
            Console.WriteLine("Wow that's not my favorite either");
            break;
    }
}

    }
}
  