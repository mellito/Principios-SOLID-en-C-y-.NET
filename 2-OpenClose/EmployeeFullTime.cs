
namespace OpenClose
{
    public class EmployeeFullTime : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public EmployeeFullTime(string fullName, int hoursWorked)
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