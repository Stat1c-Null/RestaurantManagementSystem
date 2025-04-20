using System.Diagnostics;

namespace JRestaurantSystem
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class RestaurantMap : Form
    {
        public TableView[] tableArray;
        public RestaurantMap()
        {
            InitializeComponent();

            tableArray = new TableView[]
           {
                new TableView("Table 2F", "Open", Table2FButton),
                new TableView("Table 3F", "Open", Table3FButton),
                new TableView("Table 4F", "Open", Table4FButton),
           };
        }

        private void BarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        /// <summary>
        /// Open View for each table
        /// </summary>
        /// <param name="tableID"></param>
        /// <param name="tableName"></param>
        /// <param name="status"></param>
        /// <param name="button"></param>
        private void OpenTableView(int tableID, string tableName, string status, Button button)
        {
            if (tableArray[tableID] == null || tableArray[tableID].IsDisposed)
            {
                tableArray[tableID] = new TableView(tableName, status, button);
                tableArray[tableID].Show();
            }
            else
            {
                tableArray[tableID].Show();
            }
        }

        /// <summary>
        /// Call Open Table function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Table2FButton_Click(object sender, EventArgs e)
        {
            OpenTableView(0, "Table 2F", "Open", Table2FButton);
        }

        private void Table3FButton_Click(object sender, EventArgs e)
        {
            OpenTableView(1, "Table 3F", "Open", Table3FButton);
        }

        private void Table4FButton_Click(object sender, EventArgs e)
        {
            OpenTableView(2, "Table 4F", "Open", Table4FButton);
        }
    }

    public class Waiter
    {

    }
}
