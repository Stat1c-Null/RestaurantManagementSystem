using System;
using System.Windows.Forms;

namespace JRestaurantSystem
{
    public partial class KitchenForm : Form
    {
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
            foreach (var order in Form1.OrderQueue)
            {
                listBoxOrders.Items.Add(order.ToString());
            }
        }

        private void buttonServeNext_Click(object sender, EventArgs e)
        {
            if (Form1.OrderQueue.Count > 0)
            {
                var served = Form1.OrderQueue.Dequeue();
                MessageBox.Show($"Served: {served}");
                UpdateQueueDisplay();
            }
            else
            {
                MessageBox.Show("No orders to serve.");
            }
        }
    }
}