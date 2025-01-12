namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            int[] dice = new int[6];
            int numberOfThrows = 6000;

            zeroInitialize(dice);
            ThrowDice(dice, numberOfThrows);
            DisplayValues(dice);
        }

        void zeroInitialize(int[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = 0;
            }
        }

        void ThrowDice(int[] diceCounts, int numberOfThrows)
        {
            int roll = 0;
            for (int i = 0; i < numberOfThrows; i++)
            {
                Random random = new Random();
                roll = random.Next(1, 7);
                diceCounts[roll - 1]++;
            }
        }

        void DisplayValues(int[] dice)
        {
            for (int i = 0;i < dice.Length; i++)
            {
                Console.WriteLine($"Number of throws of value {i + 1}: {dice[i]}");
            }
        }
    }
}
