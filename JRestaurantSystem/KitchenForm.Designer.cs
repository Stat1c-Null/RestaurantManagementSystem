namespace JRestaurantSystem
{
    partial class KitchenForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Button buttonServeNext;
        private System.Windows.Forms.Label labelQueue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxOrders = new ListBox();
            buttonServeNext = new Button();
            labelQueue = new Label();
            SuspendLayout();
            // 
            // listBoxOrders
            // 
            listBoxOrders.FormattingEnabled = true;
            listBoxOrders.Location = new Point(30, 50);
            listBoxOrders.Name = "listBoxOrders";
            listBoxOrders.Size = new Size(1388, 772);
            listBoxOrders.TabIndex = 0;
            // 
            // buttonServeNext
            // 
            buttonServeNext.Location = new Point(30, 270);
            buttonServeNext.Name = "buttonServeNext";
            buttonServeNext.Size = new Size(150, 30);
            buttonServeNext.TabIndex = 1;
            buttonServeNext.Text = "Serve Next Order";
            buttonServeNext.UseVisualStyleBackColor = true;
            buttonServeNext.Click += buttonServeNext_Click;
            // 
            // labelQueue
            // 
            labelQueue.AutoSize = true;
            labelQueue.Location = new Point(100, 200);
            labelQueue.Name = "labelQueue";
            labelQueue.Size = new Size(243, 48);
            labelQueue.TabIndex = 2;
            labelQueue.Text = "Orders Queue";
            // 
            // KitchenForm
            // 
            ClientSize = new Size(1784, 924);
            Controls.Add(labelQueue);
            Controls.Add(buttonServeNext);
            Controls.Add(listBoxOrders);
            Name = "KitchenForm";
            Text = "Kitchen Orders";
            Load += KitchenForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}