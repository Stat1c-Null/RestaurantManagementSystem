using System.Diagnostics;

namespace JRestaurantSystem
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class RestaurantMap : Form
    {
        public RestaurantMap()
        {
            InitializeComponent();
        }

        private void BarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void Table2FButton_Click(object sender, EventArgs e)
        {

        }
    }

    public class Waiter
    {

    }

    public class Table
    {

    }
}
