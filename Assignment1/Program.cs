namespace Assignment1
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
            int[] numbers = new int[20];

            FillArray(numbers);
            DisplayArray(numbers);
        }

        void FillArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random random = new Random();
                numbers[i] = random.Next(1, 100);
            }
        }

        void DisplayArray(int[] numbers)
        {
            for (int i = 0;i < numbers.Length;i++)
            {
                Console.WriteLine($"Element {i + 1} is {numbers[i]}");
            }
        }
    }
}
