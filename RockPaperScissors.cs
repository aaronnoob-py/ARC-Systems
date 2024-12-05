using Cosmos.Core.Memory;
using System;
using System.Runtime.Intrinsics.Arm;
using System.Threading;

public class RockPaperScissors
{
    public void RPSGame()
    {
        Console.Clear();
        Console.WriteLine("Rock Paper Scissors Game!");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Enter 'menu' to go back to Main Menu.");
        Console.WriteLine("Enter 'play' to play the game.");
        Console.ForegroundColor = ConsoleColor.White;
        string back = Console.ReadLine().ToLower();

        switch (back)
        {
            case "menu":
                Console.WriteLine("Returning to menu...");
                Thread.Sleep(1000);
                return;
            case "play":
                RPSCore();
                break;
            default:
                Console.WriteLine("Returning to Menu");
                break;

        }
    }

    public void RPSCore()
    {

        Console.Clear();
        Console.WriteLine("Welcome to Rock, Paper, Scissors!");

        Console.WriteLine("Enter your choice (rock, paper, scissors):");
        string userChoice = Console.ReadLine().ToLower();

        Random random = new Random();
        string[] options = { "rock", "paper", "scissors" };
        string computerChoice = options[random.Next(0, 3)];

        Console.WriteLine($"Computer chose: {computerChoice}");

        if (userChoice == computerChoice) { Console.WriteLine("It's a tie!"); }

        else if ((userChoice == "rock" && computerChoice == "scissors") ||
                 (userChoice == "paper" && computerChoice == "rock") ||
                 (userChoice == "scissors" && computerChoice == "paper"))
            Console.WriteLine("You win!");

        else
            Console.WriteLine("You lose!"); Thread.Sleep(1000);
        return;

    }
}
