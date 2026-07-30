namespace OpenClose
{
    public class EmployeeContractor : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public EmployeeContractor(string fullName, int hoursWorked)
        {
            Fullname = fullName;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }

    }
}