using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JRestaurantSystem
{
    public partial class Form1 : Form
    {
        public static Queue<Order> OrderQueue = new Queue<Order>();

        public Form1()
        {
            InitializeComponent();
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);  
            this.AutoScaleMode = AutoScaleMode.Font;
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            int tableNumber;
            if (!int.TryParse(textBoxTableNumber.Text, out tableNumber))
            {
                MessageBox.Show("Please enter a valid table number.");
                return;
            }

            string waiterName = comboBoxWaiters.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(waiterName))
            {
                MessageBox.Show("Please select a waiter.");
                return;
            }

            List<string> selectedItems = new List<string>();
            foreach (object item in checkedListBoxItems.CheckedItems)
            {
                selectedItems.Add(item.ToString());
            }

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item.");
                return;
            }

            //Order newOrder = new Order(tableNumber, waiterName, selectedItems);
            //OrderQueue.Enqueue(newOrder);

            MessageBox.Show("Order placed and added to kitchen queue.");
        }

        private void buttonViewKitchen_Click(object sender, EventArgs e)
        {
            KitchenForm kitchenForm = new KitchenForm();
            kitchenForm.Show();
        }

        private void buttonOpenKitchen_Click(object sender, EventArgs e)
        {
            KitchenForm kitchenForm = new KitchenForm();
            kitchenForm.Show();
        }

    }
}