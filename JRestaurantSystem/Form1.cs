using System.Diagnostics;

namespace JRestaurantSystem
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class RestaurantMap : Form
    {
        public static TableView[] tableArray;
        private static int openTables;
        private static int dirtyTables;
        private static int occupiedTables;

        /// <summary>
        /// Constructor to initialize array of all tables in the restaurant
        /// </summary>
        public RestaurantMap()
        {
            InitializeComponent();

            tableArray = new TableView[]
           {
                new TableView("Table 1F", "OPEN", Table1FButton),
                new TableView("Table 2F", "OPEN", Table2FButton),
                new TableView("Table 3F", "OPEN", Table3FButton),
                new TableView("Table 4F", "OPEN", Table4FButton),
                new TableView("Table 5F", "OPEN", Table5FButton),
                new TableView("Table 6F", "OPEN", Table6FButton),
                new TableView("Table 1E", "OPEN", Table1EButton),
                new TableView("Table 2E", "OPEN", Table2EButton),
                new TableView("Table 3E", "OPEN", Table3EButton),
                new TableView("Table 4E", "OPEN", Table4EButton),
                new TableView("Table 5E", "OPEN", Table5EButton),
                new TableView("Table 6E", "OPEN", Table6EButton),
                new TableView("Table 5D", "OPEN", Table5DButton),
                new TableView("Table 6D", "OPEN", Table6DButton),
                new TableView("Table 5C", "OPEN", Table5CButton),
                new TableView("Table 6C", "OPEN", Table6CButton),
                new TableView("Table 1B", "OPEN", Table1BButton),
                new TableView("Table 2B", "OPEN", Table2BButton),
                new TableView("Table 3B", "OPEN", Table3BButton),
                new TableView("Table 4B", "OPEN", Table4BButton),
                new TableView("Table 5B", "OPEN", Table5BButton),
                new TableView("Table 6B", "OPEN", Table6BButton),
                new TableView("Table 1A", "OPEN", Table1AButton),
                new TableView("Table 2A", "OPEN", Table2AButton),
                new TableView("Table 3A", "OPEN", Table3AButton),
                new TableView("Table 4A", "OPEN", Table4AButton),
                new TableView("Table 5A", "OPEN", Table5AButton),
                new TableView("Table 6A", "OPEN", Table6AButton),
                new TableView("Table 4C", "OPEN", Table4CButton),
                new TableView("Table 4D", "OPEN", Table4DButton),
           };

            updateTableCounter();
        }

        /// <summary>
        /// Update the counter of Open, Occupied and Dirty tables in the restaurant map menu
        /// </summary>
        public static void updateTableCounter()
        {
            openTables = 0;
            occupiedTables = 0;
            dirtyTables = 0;

            for (int i = 0; i < tableArray.Length; i++)
            {
                if (tableArray[i].tableStatus == "OPEN")
                {
                    openTables++;
                } else if (tableArray[i].tableStatus == "OCCUPIED")
                {
                    occupiedTables++;
                } else if (tableArray[i].tableStatus == "DIRTY")
                {
                    dirtyTables++;
                }
            }

            OpenTablesLabel.Text = openTables + "/30";
            OccupiedTablesLabel.Text = occupiedTables + "/30";
            DirtyTablesLabel.Text = dirtyTables + "/30";
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
        /// Call Open Table functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Table2FButton_Click(object sender, EventArgs e)
        {
            OpenTableView(1, "Table 2F", "Open", Table2FButton);
        }

        private void Table3FButton_Click(object sender, EventArgs e)
        {
            OpenTableView(2, "Table 3F", "Open", Table3FButton);
        }

        private void Table4FButton_Click(object sender, EventArgs e)
        {
            OpenTableView(3, "Table 4F", "Open", Table4FButton);
        }

        private void Table1FButton_Click(object sender, EventArgs e)
        {
            OpenTableView(0, "Table 1F", "Open", Table1FButton);
        }

        private void Table5FButton_Click(object sender, EventArgs e)
        {
            OpenTableView(4, "Table 5F", "Open", Table5FButton);
        }

        private void Table6FButton_Click(object sender, EventArgs e)
        {
            OpenTableView(5, "Table 6F", "Open", Table6FButton);
        }

        private void Table1EButton_Click(object sender, EventArgs e)
        {
            OpenTableView(6, "Table 1E", "Open", Table1EButton);
        }

        private void Table2EButton_Click(object sender, EventArgs e)
        {
            OpenTableView(7, "Table 2E", "Open", Table2EButton);
        }

        private void Table3EButton_Click(object sender, EventArgs e)
        {
            OpenTableView(8, "Table 3E", "Open", Table3EButton);
        }

        private void Table4EButton_Click(object sender, EventArgs e)
        {
            OpenTableView(9, "Table 4E", "Open", Table4EButton);
        }

        private void Table5EButton_Click(object sender, EventArgs e)
        {
            OpenTableView(10, "Table 5E", "Open", Table5EButton);
        }

        private void Table6EButton_Click(object sender, EventArgs e)
        {
            OpenTableView(11, "Table 6E", "Open", Table6EButton);
        }

        private void Table5DButton_Click(object sender, EventArgs e)
        {
            OpenTableView(12, "Table 5D", "Open", Table5DButton);
        }

        private void Table6DButton_Click(object sender, EventArgs e)
        {
            OpenTableView(13, "Table 6D", "Open", Table6DButton);
        }

        private void Table5CButton_Click(object sender, EventArgs e)
        {
            OpenTableView(14, "Table 5C", "Open", Table5CButton);
        }

        private void Table6CButton_Click(object sender, EventArgs e)
        {
            OpenTableView(15, "Table 6C", "Open", Table6CButton);
        }

        private void Table1BButton_Click(object sender, EventArgs e)
        {
            OpenTableView(16, "Table 1B", "Open", Table1BButton);
        }

        private void Table2BButton_Click(object sender, EventArgs e)
        {
            OpenTableView(17, "Table 2B", "Open", Table2BButton);
        }

        private void Table3BButton_Click(object sender, EventArgs e)
        {
            OpenTableView(18, "Table 3B", "Open", Table3BButton);
        }

        private void Table4BButton_Click(object sender, EventArgs e)
        {
            OpenTableView(19, "Table 4B", "Open", Table4BButton);
        }

        private void Table5BButton_Click(object sender, EventArgs e)
        {
            OpenTableView(20, "Table 5B", "Open", Table5BButton);
        }

        private void Table6BButton_Click(object sender, EventArgs e)
        {
            OpenTableView(21, "Table 6B", "Open", Table6BButton);
        }

        private void Table1AButton_Click(object sender, EventArgs e)
        {
            OpenTableView(22, "Table 1A", "Open", Table1AButton);
        }

        private void Table2AButton_Click(object sender, EventArgs e)
        {
            OpenTableView(23, "Table 2A", "Open", Table2AButton);
        }

        private void Table3AButton_Click(object sender, EventArgs e)
        {
            OpenTableView(24, "Table 3A", "Open", Table3AButton);
        }

        private void Table4AButton_Click(object sender, EventArgs e)
        {
            OpenTableView(25, "Table 4A", "Open", Table4AButton);
        }

        private void Table5AButton_Click(object sender, EventArgs e)
        {
            OpenTableView(26, "Table 5A", "Open", Table5AButton);
        }

        private void Table6AButton_Click(object sender, EventArgs e)
        {
            OpenTableView(27, "Table 6A", "Open", Table6AButton);
        }

        private void Table4CButton_Click(object sender, EventArgs e)
        {
            OpenTableView(28, "Table 4C", "Open", Table4CButton);
        }

        private void Table4DButton_Click(object sender, EventArgs e)
        {
            OpenTableView(29, "Table 4D", "Open", Table4DButton);
        }
    }

    public class Waiter
    {
        public static TableView[] assignedTables;
        public string name;
        public int employeeNum;
    }
}
