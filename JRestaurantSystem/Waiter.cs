using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRestaurantSystem
{
    /// <summary>
    /// Represents a waiter in the restaurant system with name, employee number, etc
    /// </summary>
    public class Waiter
    {
        private string name;
        private int hoursWorked;
        private int employeeNum;

        /// <summary>
        /// Constructor that initializes a Waiter with a name and PIN
        /// </summary>
        /// <param name="name">Waiter name</param>
        /// <param name="employeeNum">Unique PIN# for employees.</param>
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

        /// <summary>
        /// Logs out the waiter if the entered PIN matches the waiter's PIN.
        /// </summary>
        /// <param name="employeeNum">Employee's PIN</param>
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

    ////// <summary>
    /// Static class to manages assigned tables waiters using a dictionary that gives waiter PINs to table numbers.
    /// </summary>
    public static class TableAssignments
    {
        public static Dictionary<int, List<int>> waiterTableMap = new Dictionary<int, List<int>>()
    {
        { 1111, new List<int> { 1, 2,3,4,5,6 } },
        { 2222, new List<int> { 7,8,9,10,11,12 } },
        { 3333, new List<int> { 13,14,15,16,17,18 } },
        { 4444, new List<int> { 19,20,21,22,23,24 } },
        { 5555, new List<int> { 25,26,27,28,29,0 } },
    };
    }
}