using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRestaurantSystem
{
    public class Waiter
    {
        private string name;
        private int hoursWorked;
        private int employeeNum;

        public Waiter(string name, int employeeNum)
        {
            this.name = name;
            this.employeeNum = employeeNum;
            hoursWorked = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int EmployeeNum
        {
            get { return employeeNum; }
        }

        public void LogOut(int employeeNum)
        {
            if (this.employeeNum == employeeNum)
            {
                Console.WriteLine($"Waiter {name} logged out.");
            }
            else
            {
                Console.WriteLine("Employee number doesn't match.");
            }
        }
    }
}
