namespace Assignment3
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
            int[] numarray = new int[3];

            Console.WriteLine("Enter 3 integers:");

            FillArray(numarray);

            int sum = CalculateSum(numarray);
            double average = CalculateAverage(numarray);

            Console.WriteLine($"Sum = {sum}\n" +
                $"Average = {average}");


        }

        void FillArray (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string input = Console.ReadLine();
                array[i] = int.Parse(input);
            }
        }

        int CalculateSum (int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        double CalculateAverage (int[] array)
        {
            int sum = 0;
            double average = 0;

            for (int i = 0;i < array.Length;i++)
            {
                sum = sum + array[i];
            }

            average = (double)sum / (double)array.Length;

            return average;
        }
    }
}
