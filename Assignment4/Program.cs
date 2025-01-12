namespace Assignment4
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
            Console.WriteLine("Enter Course name:");
            string course = Console.ReadLine();

            Console.WriteLine("Enter number of students");
            string input = Console.ReadLine();
            int students = int.Parse(input);

            string[] names = new string[students];
            int[] grades = new int[students];

            ReadNames(names);
            ReadGrades(grades);

            int highest = GetHighestGrade(grades);

            Console.WriteLine($"Student {names[highest]} has the highest grade: {grades[highest]}");
        }

        void ReadNames(string[] names)
        {
            for (int i =  0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter name of student {i + 1}: ");
                string name = Console.ReadLine();

                names[i] = name;
            }
        }

        void ReadGrades(int[] grades)
        {
            for (int i = 0;i < grades.Length;i++)
            {
                Console.WriteLine($"Enter grade of student {i + 1}:");
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                grades[i] = grade;
            }
        }

        int GetHighestGrade(int[] grades)
        {
            int highest = grades[0];

            for (int i = 0;i < grades.Length;i++)
            {
                for (int j = 1;j < grades.Length;j++)
                {
                    if (grades[i] > grades[j])
                    {
                        highest = i;
                        i = j;
                        j = highest;
                    }
                }
            }

            return highest;
        }
    }
}
