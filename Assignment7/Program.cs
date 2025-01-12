namespace Assignment7
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
            bool[] seats = new bool[10];

            InitializeSeats(seats);
            DisplayArrangement(seats);
            BookSeat(seats);
        }

        void InitializeSeats(bool[] seats)
        {
            for (int i = 0; i < seats.Length; i++)
            {
                var random = new Random();
                seats[i] = random.Next(2) == 1;
            }
        }

        void DisplayArrangement(bool[] seats)
        {
            string[] booking = {"Booked", "Available"};
            for (int i = 0;i < seats.Length;i++)
            {
                if (seats[i] == true)
                    Console.WriteLine($"Seat {i + 1}: {booking[1]}");
                else if (seats[i] == false)
                    Console.WriteLine($"Seat {i + 1}: {booking[0]}");
            }
        }

        void BookSeat(bool[] seats)
        {
            int error = 1;

            while (error == 1)
            {
                Console.WriteLine("Enter the seat number you want to book: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                if (seats[number - 1] == true)
                {
                    Console.WriteLine($"Seat {number} has been successfully booked.");

                    seats[number - 1] = false;
                    DisplayArrangement(seats);
                    error = 0;
                }
                else if (seats[number - 1] == false)
                {
                    Console.WriteLine("Error! Please select an available seat!");
                }
            }
        }
    }
}
