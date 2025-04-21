using System;
using System.Windows.Forms;

namespace JRestaurantSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // <--- this must be Form1
        }
    }
}
