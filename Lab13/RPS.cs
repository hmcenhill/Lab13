using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public static class RPS
    {
        public static void Run()
        {
            var score = new Score();
            var user = new User(Greet());
            var opponent = ChooseOpponent();
            Console.WriteLine($"{opponent.Name}: {opponent.Taunt()}\nPress any key to begin!");
            Console.ReadKey();
            do
            {
                DisplayScore(score, user, opponent);
                PlayRound(score, user, opponent);
            } while (Validator.KeepGoing("Would you like to play another round?"));

            Console.Clear();
            Console.WriteLine($"\n\nFinal Score: You - {score.Wins}, {opponent.Name} - {score.Losses}, and {score.Draws} draws.\nThanks for playing!");
        }
        private static void PlayRound(Score score, User user, Player opponent)
        {
            user.Throw = user.GenerateRoshambo();
            opponent.Throw = opponent.GenerateRoshambo();
            Console.WriteLine($"\nYou played {user.Throw} and {opponent.Name} played {opponent.Throw}");
            if (user.Throw == opponent.Throw)
            {
                Console.WriteLine("Draw!");
                score.Draws++;
            }
            else if (user.Throw == Roshambo.Rock && opponent.Throw == Roshambo.Scissors)
            {
                Console.WriteLine($"You win! {user.Throw} beats {opponent.Throw}");
                score.Wins++;
            }
            else if (user.Throw == Roshambo.Scissors && opponent.Throw == Roshambo.Rock)
            {
                Console.WriteLine($"You Lose! {opponent.Throw} beats {user.Throw}");
                score.Losses++;
            }
            else if (user.Throw > opponent.Throw)
            {
                Console.WriteLine($"You win! {user.Throw} beats {opponent.Throw}");
                score.Wins++;
            }
            else
            {
                Console.WriteLine($"You Lose! {opponent.Throw} beats {user.Throw}");
                score.Losses++;
            }
        }
        public static string Greet()
        {
            Console.WriteLine("Welcome to Roshambo! What is your name?");
            var input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("Can't think of anything, we'll just call you BOB!");
                return "BOB";
            }
            return input;
        }
        public static Player ChooseOpponent()
        {
            Console.WriteLine("Choose an Oppoent:");
            Console.WriteLine("1 - The Rock\n2 - Ricky Random\n3 - Chester Cheater\n4 - Tricky Terrance");
            switch (Validator.GetInt(1, 4))
            {
                case 1:
                    return new TheRock();
                case 2:
                    return new Ricky();
                default:
                    return new TheRock();
            }
        }
        public static void DisplayScore(Score score, User user, Player opponent)
        {
            Console.Clear();
            var scores = new string($"| {user.Name} - {score.Wins} | {opponent.Name} - {score.Losses} | Draws - {score.Draws} |");
            Console.WriteLine(new string('-', scores.Length));
            Console.WriteLine(scores);
            Console.WriteLine(new string('-', scores.Length));
            Console.WriteLine();
        }
    }
}
