Random random = new Random();
int number = random.Next(1, 100);
bool guess = false;
int guesses = 0;
while (guess == false)
{
    Console.WriteLine($"Pick a number between 1- 100");
    int numbGuess = Convert.ToInt32(Console.ReadLine());

    if (numbGuess == number)
    {
        Console.WriteLine($"You guessed the right number!");
        Console.WriteLine($"The number was {number}");
        Console.WriteLine($"Guesses: {guesses}");
        Console.WriteLine("Do you wanna play again? \n Type (y) or (n)");
        string again = Console.ReadLine();
        if (again == "n")
        {
            guess = true;
        }
        else if (again == "y")
        {
            Console.Clear();
            guesses = 0;
            number = random.Next(1, 100);
            continue;
        }
    }
    else if (numbGuess < number)
    {
        Console.WriteLine("You need to go Higher");
    }
    else if (numbGuess > number)
    {
        Console.WriteLine("You need to go Lower!");
    }
    guesses++;
}
