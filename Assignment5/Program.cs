using System.Diagnostics.Metrics;
using System.Transactions;

namespace Assignment5
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
            int[] num = new int[99];
            ReadNumber(num);

            Console.WriteLine("Enter search number:");
            string input = Console.ReadLine();
            int searchvalue = int.Parse(input);

            int searchcount = CountSearchValue(num, searchvalue);

            Console.WriteLine($"Number of occurences of search value({searchvalue}) is: {searchcount}");
        }

        void ReadNumber(int[] num)
        {

            int enter = 1;

            while (enter != 0)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    Console.WriteLine("Enter a number (0 = stop):");
                    string input = Console.ReadLine();
                    enter = int.Parse(input);

                    num[i] = enter;

                    if (enter == 0)
                    {
                        break;
                    }
                }
            }
            
        }

        int CountSearchValue(int[] num, int value)
        {
            int count = 0;

            for (int i = 0;i < num.Length;i++)
            {
                if (num[i] == value)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
