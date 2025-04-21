namespace JRestaurantSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxTableNumber;
        private System.Windows.Forms.ComboBox comboBoxWaiters;
        private System.Windows.Forms.CheckedListBox checkedListBoxItems;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Button buttonViewKitchen;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.textBoxTableNumber = new System.Windows.Forms.TextBox();
            this.comboBoxWaiters = new System.Windows.Forms.ComboBox();
            this.checkedListBoxItems = new System.Windows.Forms.CheckedListBox();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.buttonViewKitchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // textBoxTableNumber
            //
            this.textBoxTableNumber.Location = new System.Drawing.Point(12, 12);
            this.textBoxTableNumber.Name = "textBoxTableNumber";
            this.textBoxTableNumber.PlaceholderText = "Enter Table Number";
            this.textBoxTableNumber.Size = new System.Drawing.Size(200, 23);
            //
            // comboBoxWaiters
            //
            this.comboBoxWaiters.FormattingEnabled = true;
            this.comboBoxWaiters.Items.AddRange(new object[] {
                "Alice", "Bob", "Charlie"});
            this.comboBoxWaiters.Location = new System.Drawing.Point(12, 50);
            this.comboBoxWaiters.Name = "comboBoxWaiters";
            this.comboBoxWaiters.Size = new System.Drawing.Size(200, 23);
            //
            // checkedListBoxItems
            //
            this.checkedListBoxItems.FormattingEnabled = true;
            this.checkedListBoxItems.Items.AddRange(new object[] {
                "Burger", "Fries", "Salad", "Pizza", "Soda"});
            this.checkedListBoxItems.Location = new System.Drawing.Point(12, 90);
            this.checkedListBoxItems.Name = "checkedListBoxItems";
            this.checkedListBoxItems.Size = new System.Drawing.Size(200, 94);
            //
            // buttonPlaceOrder
            //
            this.buttonPlaceOrder.Location = new System.Drawing.Point(12, 200);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(200, 23);
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            //
            // buttonViewKitchen
            //
            this.buttonViewKitchen.Location = new System.Drawing.Point(12, 230);
            this.buttonViewKitchen.Name = "buttonViewKitchen";
            this.buttonViewKitchen.Size = new System.Drawing.Size(200, 23);
            this.buttonViewKitchen.Text = "View Kitchen Queue";
            this.buttonViewKitchen.Click += new System.EventHandler(this.buttonViewKitchen_Click);
            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(234, 270);
            this.Controls.Add(this.textBoxTableNumber);
            this.Controls.Add(this.comboBoxWaiters);
            this.Controls.Add(this.checkedListBoxItems);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.buttonViewKitchen);
            this.Name = "Form1";
            this.Text = "Order System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}