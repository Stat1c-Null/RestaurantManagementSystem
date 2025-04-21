using System;
using System.Windows.Forms;

namespace JRestaurantSystem
{
    public partial class KitchenForm : Form
    {
        public Queue<Order> OrderQueue = new Queue<Order>();

        public KitchenForm()
        {
            InitializeComponent();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            UpdateQueueDisplay();
        }

        private void UpdateQueueDisplay()
        {
            listBoxOrders.Items.Clear();
            foreach (var order in OrderQueue)
            {
                listBoxOrders.Items.Add(order.ToString());
            }
        }

        private void buttonServeNext_Click(object sender, EventArgs e)
        {
            if (OrderQueue.Count > 0)
            {
                var served = OrderQueue.Dequeue();
                MessageBox.Show($"Served: {served}");
                UpdateQueueDisplay();
            }
            else
            {
                MessageBox.Show("No orders to serve.");
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateQueueDisplay();
        }
    }
}