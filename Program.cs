namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random unknownAiChoice = new Random(); 

            int playerScore = 0;
            int aiScore = 0;

            Console.WriteLine("Welcome to the Rock, Paper, Scissors game.");

            while (playerScore != 3 && aiScore != 3)
            {
                Console.WriteLine("Player Score is - " + playerScore + " and AI Score is - " + aiScore);
                Console.Write("PLayer should enter 'r' for rock, 'p' for paper and any letter for scissors: ");
                string playerChoice = Console.ReadLine();
                int aiChoice = unknownAiChoice.Next(0, 3);

                if (aiChoice == 0)
                {
                    Console.WriteLine("Ai chooses rock");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player chooses rock.");
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player chooses paper.");
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Player chooses scissors.");
                            Console.WriteLine("Ai wins this round.");
                            aiScore++; 
                            break;
                        

                    }
                }
                else if (aiChoice == 1) 
                {
                    Console.WriteLine("Ai chooses paper");

                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player chooses rock.");
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Player chooses paper.");
                            Console.WriteLine("Tie!");
                            break;
                        default:
                            Console.WriteLine("Player chooses scissors.");
                            Console.WriteLine("Ai wins this round.");
                            aiScore++;
                            break;
                    }

                } 
                else
                {
                    Console.WriteLine("Ai chooses  scissors");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player chooses rock.");
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break; 
                        case "p":
                            Console.WriteLine("Player chooses paper.");
                            Console.WriteLine("Ai wins this round.");
                            aiScore++;
                            break;
                        default:
                            Console.WriteLine("Player chooses scissors.");
                            Console.WriteLine("Tie!");
                            break;
                    }
                }
            }

            if (playerScore == 3)
            {
                Console.WriteLine("You Win!");
            } else
            { 
                Console.WriteLine("You Lose!");
            }


            Console.ReadLine();
        }
    }
}