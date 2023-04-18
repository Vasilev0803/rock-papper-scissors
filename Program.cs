bool playAgain = true;
int playerScore = 0;
int computerScore = 0;

while (playAgain)
{
    Console.WriteLine("Let's play Rock, Paper, Scissors!");
    Console.WriteLine("Choose [r]ock, [p]aper, or [s]cissors:");
    string playerInput = Console.ReadLine().ToLower();

    string playerMove;
    if (playerInput == "r")
    {
        playerMove = "rock";
    }
    else if (playerInput == "p")
    {
        playerMove = "paper";
    }
    else if (playerInput == "s")
    {
        playerMove = "scissors";
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
        continue;
    }

    Random rand = new Random();
    int computerMove = rand.Next(1, 4);
    string computerMoveString = "";
    if (computerMove == 1)
    {
        computerMoveString = "rock";
    }
    else if (computerMove == 2)
    {
        computerMoveString = "paper";
    }
    else if (computerMove == 3)
    {
        computerMoveString = "scissors";
    }

    Console.WriteLine($"The computer chose {computerMoveString}.");

    if (playerMove == computerMoveString)
    {
        Console.WriteLine("It's a tie!");
    }
    else if (playerMove == "rock" && computerMoveString == "scissors" ||
             playerMove == "paper" && computerMoveString == "rock" ||
             playerMove == "scissors" && computerMoveString == "paper")
    {
        Console.WriteLine("You win!");
        playerScore++;
    }
    else
    {
        Console.WriteLine("The computer wins!");
        computerScore++;
    }

    Console.WriteLine($"The score is: Player {playerScore} - {computerScore} Computer");

    Console.WriteLine("Do you want to play again? (y/n)");
    string playAgain1 = Console.ReadLine().ToLower();
    if (playAgain1 == "n" || playAgain1 == "no")
    {
        playAgain = false;
    }
}