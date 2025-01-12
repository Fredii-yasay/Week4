using System.Transactions;

namespace AssignmentReview
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
            string[] names = new string[3];
            int[] grades = new int[3];

            Console.WriteLine("Enter Course: ");
            string course = Console.ReadLine();

            ReadNames(names);
            ReadGrades(names, grades);
            int returnval = GetHighestGradeIndex(grades);

            Console.WriteLine($"Student {names[returnval]} has the highest grade: {grades[returnval]}");
        }

        void ReadNames (string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter name of student {i + 1}: ");
                names[i] = Console.ReadLine();
            }
        }

        void ReadGrades (string[] names, int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Enter grade of {names[i]}: ");
                string number = Console.ReadLine();
                grades[i] = int.Parse(number); 
            }
        }

        int GetHighestGradeIndex(int[] grades)
        {
            int comparenum = 0;
            int index = 0;

            for (int i = 0;i < grades.Length; i++)
            {
                if (grades[i] > comparenum)
                {
                    comparenum = grades[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
