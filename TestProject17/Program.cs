internal class Program
{
    private static void Main(string[] args)
    {
        // string input = "there are snakes at the zoo";

        // Console.WriteLine(input);                          //there are snakes at the zoo
        // Console.WriteLine(ReverseSentence(input));         //ereht era sekans ta eht ooz

        // string ReverseSentence(string input)
        // {
        //     string result = "";
        //     string[] words = input.Split(" "); //用split将句子分割成一个个单独的词
        //     foreach (string word in words)
        //     {
        //         result += ReverseWord(word) + " ";
        //     }
        //     return result.Trim();
        // }

        // string ReverseWord(string word)        //将每一个单词反转
        // {
        //     string result = "";
        //     for (int i = word.Length - 1; i >= 0; i--)
        //     {
        //         result += word[i];
        //     }
        //     return result;
        // }




        int target = 30;
        int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
        int[,] result = TwoCoins(coins, target);

        if (result.Length == 0)
        {
            Console.WriteLine("No two coins make change");
        }
        else
        {
            Console.WriteLine("Change found at positions:");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                if (result[i, 0] == -1)
                {
                    break;
                }
                Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
            }
        }

        int[,] TwoCoins(int[] coins, int target)
        {
            int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
            int count = 0;

            for (int curr = 0; curr < coins.Length; curr++)
            {
                for (int next = curr + 1; next < coins.Length; next++)
                {
                    if (coins[curr] + coins[next] == target)
                    {
                        result[count, 0] = curr;
                        result[count, 1] = next;
                        count++;
                    }
                    if (count == result.GetLength(0))
                    {
                        return result;
                    }
                }
            }
            return (count == 0) ? new int[0, 0] : result;
        }
    }
}