/*Your challenge is to design a mini-game. 
The game should select a target number that is a random number between one and five (inclusive). 
The player must roll a six-sided dice. To win, the player must roll a number greater than the target number.
 At the end of each round, the player should be asked if they would like to play again, and the game should continue or terminate accordingly.
*/

internal class Program                                             
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }

        bool ShouldPlay()
        {
            string response = Console.ReadLine() ?? ""; // ??""表示如果 ReadLine 返回 null，则使用空字符串 
            return response.ToLower().Equals("y");
        }

        void PlayGame()
        {
            var play = true;

            while (play)
            {
                int target = random.Next(1, 6);
                int roll = random.Next(1, 7);

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(roll,target));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }
        string WinOrLose(int roll, int target)
        {
            if (roll > target)
            {
                return "You win!";
            }
            return "You lose!";
        }
    }
}
/*Would you like to play? (Y/N)
Y
Roll a number greater than 1 to win!
You rolled a 2
You win!

Play again? (Y/N)
Y
Roll a number greater than 4 to win!
You rolled a 6
You win!

Play again? (Y/N)
Y
Roll a number greater than 1 to win!
You rolled a 1
You lose!

Play again? (Y/N)
N
*/