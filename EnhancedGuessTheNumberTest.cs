using System;


class EnhancedGuessTheNumberTest
{
    public int counter = 0;
    static void Main()
    {
        EnhancedGuessTheNumber guessTheNumber = new EnhancedGuessTheNumber();

        Random randomNumber = new Random();


        Console.Write("\t\t>>>>>>>>>>>> Hello World! <<<<<<<<<<<<\n\n\n");

        int theNumber = randomNumber.Next(1, 1001);

        int count = 0;
        string yes = "y";
        string no = "n";

        do
        {
            Console.Write("Guess a number between 1 and 1000: ");
            int guessTheNumbertheGuess = int.Parse(Console.ReadLine());
            guessTheNumber.SetGuess(guessTheNumbertheGuess);

            if (guessTheNumbertheGuess == theNumber)
            {
                Console.WriteLine("\n\nCongratulations. You guessed the number!");
                break;
            }
            else if (guessTheNumbertheGuess < theNumber)
            {
                Console.WriteLine("Too low. Try again.");
                ++count;
                continue;
            }
            else if (guessTheNumbertheGuess <= 0 || guessTheNumbertheGuess > 1000)
            {
                Console.WriteLine("The number you gave is out of range...go again!");
                continue;
            }
            else
            {
                Console.WriteLine("Too high. Try again.");
                ++count;
                continue;
            }

        } while (guessTheNumber.GetGuess() != theNumber);

        if (count < 10)
        {
            Console.WriteLine("\nEither you know the secret or you got lucky!");
        }
        else if (count == 10)
        {
            Console.WriteLine("\nAha! You know the secret!");
        }
        else
            Console.WriteLine("\nYou should be able to do better!\n\n");

        do
        {
            Console.Write("\nWould you like to play again y or n: ");
            string guessTheNumberthechoice = Console.ReadLine();
            guessTheNumber.SetChoice(guessTheNumberthechoice);

            if (guessTheNumberthechoice == yes)
            {
                EnhancedGuessTheNumberTest.Main();
            }
            else if (guessTheNumberthechoice == no)
            {
                Console.WriteLine("\nSorry to see you going so quick..");
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter y or n!");
                continue;
            }
        } while (guessTheNumber.GetChoice() != yes || guessTheNumber.GetChoice() != no);

        Console.WriteLine("\n\n\t\t======= Thank you and see you next time! =======");

    }
}

