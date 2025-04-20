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

        /// <summary>
        /// Open Table View Window and pass in the name of the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Table2FButton_Click(object sender, EventArgs e)
        {
            string tableName = "Table 2F";
            TableView table2F = new TableView(tableName);

            table2F.Show();
        }
    }

    public class Waiter
    {

    }

    public class Table
    {

    }
}
