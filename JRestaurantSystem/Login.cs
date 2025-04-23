using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRestaurantSystem
{
    /// <summary>
    /// Has the login functionality for waiters by reading the file
    /// verifying logins, and managing the currently logged-in waiter
    /// </summary>
    public class Login
    {
        private List<Waiter> waiters;
        private List<int> employeeLoginNums;
        private static Waiter currentWaiter;
        private string filePath;

        /// <summary>
        /// new instance of the <see cref="Login"/> class and loads waiter & from the file
        /// </summary>
        public Login()
        {
            waiters = new List<Waiter>();
            employeeLoginNums = new List<int>();
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "waiters.txt");
            LoadWaitersFromFile();
        }

        /// <summary>
        /// Loads waiter data from the file 
        /// </summary>
        private void LoadWaitersFromFile()
        {
            try
            {

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 2)
                        {
                            string name = parts[0].Trim();
                            if (int.TryParse(parts[1].Trim(), out int pin))
                            {
                                Waiter waiter = new Waiter(name, pin);
                                waiters.Add(waiter);
                                employeeLoginNums.Add(pin);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// logs in a waiter using their PIN
        /// </summary>
        /// <param name="employeeNum">PIN waiter enters</param>
        /// <returns>True if login is successful; otherwise, false.</returns>
        public bool logIn(int employeeNum)
        {
            if (employeeLoginNums.Contains(employeeNum))
            {
                currentWaiter = null;
                foreach (Waiter waiter in waiters)
                {
                    if (waiter.EmployeeNum == employeeNum)
                    {
                        currentWaiter = waiter;
                        break;
                    }
                }
                Console.WriteLine("correct");
                return true;
            }
            else
            {
                Console.WriteLine("wrong");
                return false;
            }
        }

        /// <summary>
        /// Logs out the waiter that's logged in now if the number matches
        /// </summary>
        /// <param name="employeeNum">PIN of the waiter logging out</param>
        public static void logOut(int employeeNum)
        {
            if (currentWaiter != null && currentWaiter.EmployeeNum == employeeNum)
            {
                currentWaiter.LogOut(employeeNum);
                currentWaiter = null;
            }
            else
            {
                Console.WriteLine("No waiter is currently logged in");
            }
        }

        //Gets the current loggedin waiter
        public Waiter GetCurrentWaiter()
        {
            return currentWaiter;
        }

        //To check if the waiter file exists
        public bool WaitersFileExists()
        {
            return File.Exists(filePath);
        }
    }
}