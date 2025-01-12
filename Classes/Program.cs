namespace Classes
{
    internal class Employee
    {
        public string firstName, lastName;
        public string department;
        public int salary;
    }

    public void IncreaseSalary (float increase)
    {
        salary = salary + increase;
    }
}
