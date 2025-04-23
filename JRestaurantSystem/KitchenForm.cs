using System;
using System.Windows.Forms;

namespace JRestaurantSystem
{
    public partial class KitchenForm : Form
    {
        //Creates an public queue to use for showing the orders get queued and dequeued for the kitchen people
        public Queue<Order> OrderQueue = new Queue<Order>();

        public KitchenForm()
        {
            InitializeComponent();
        }

        //update queue method to update the queue happens when we load the screen
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

        //To dequeue the orders when the order is complete in the kitchen(served)
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

        //Refreshes the update queue manuallyy
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateQueueDisplay();
        }
    }
}