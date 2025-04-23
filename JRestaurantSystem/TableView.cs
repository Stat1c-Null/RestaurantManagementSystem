using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tsunami;

namespace JRestaurantSystem
{
    public partial class TableView : Form
    {
        public string tableNumber;
        public string tableStatus;
        public int numberOfSeats;
        private Button tableButton;

        private Waiter loggedInWaiter;

        private KitchenForm kitchenForm;

        /// <summary>
        /// Constructor class that initializes a Table class with tableNumber, status and button assigned to it from restaurant map
        /// </summary>
        /// <param name="tableNum"></param>
        /// <param name="status"></param>
        /// <param name="button"></param>
        /// <param name="loggedInWaiter"></param>
        public TableView(string tableNum, string status, Button button, Waiter loggedInWaiter)
        {
            InitializeComponent();

            tableNumber = tableNum;
            PageLabel.Text = tableNumber;

            tableStatus = status;

            numberOfSeats = 4;

            tableButton = button;
            this.loggedInWaiter = loggedInWaiter;

            kitchenForm = new KitchenForm();
        }

        // Public method to update button color at the start of the screen for each waiter
        public void UpdateTableButtonColor(Color color)
        {
            tableButton.BackColor = color;
        }

        /// <summary>
        /// Close TableView window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Update Status of the table and color of the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = StatusSelector.Text;
            tableStatus = StatusSelector.Text;

            switch (tableStatus)
            {
                case "OPEN":
                    tableButton.BackColor = Color.Lime;
                    break;
                case "OCCUPIED":
                    tableButton.BackColor = Color.Yellow;
                    break;
                case "DIRTY":
                    tableButton.BackColor = Color.Red;
                    break;
                default:
                    tableButton.BackColor = Color.Black;
                    break;
            }

            RestaurantMap.updateTableCounter();
        }

        /// <summary>
        /// If user is closing window by clicking X at the top right corner, hide window instead
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                e.Cancel = true;

                this.Hide();
            }
        }

        private void TableView_Load(object sender, EventArgs e)
        {

        }

        private void PageLabel_Click(object sender, EventArgs e)
        {

        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            OrderSystem order = new OrderSystem(loggedInWaiter.Name, tableNumber, kitchenForm);
            order.Show();
        }

        private void viewOrderButton_Click(object sender, EventArgs e)
        {
            kitchenForm.Show();
        }
    }
}