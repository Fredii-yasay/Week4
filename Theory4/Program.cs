using System.Numerics;

namespace Theory4
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
            string[] month = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            int[] profit = new int[12];
            int total = 0;

            for (int i = 0; i < profit.Length; i++)
            {
                Console.WriteLine($"Enter profit for {month[i]}: ");
                profit [i] = int.Parse(Console.ReadLine());
                total = total + profit[i];
            }

            double average = (double)total / profit.Length;

            for (int i = 0;i < profit.Length;i++)
            {
                if (profit [i] > average)
                {
                    Console.WriteLine($"{month[i]} : {profit[i]}");
                }
            }
        }
    }
}
