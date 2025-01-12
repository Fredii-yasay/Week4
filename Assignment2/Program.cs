namespace Assignment2
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
            
            int smallest = GetSmallestNumber(numbers);

            Console.WriteLine($"The smallest number is: {smallest}");
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
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i + 1} is {numbers[i]}");
            }
        }

        int GetSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];

            for (int i = 0;i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        smallest = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = smallest;
                    }
                }
            }

            return smallest;
        }
    }
}
