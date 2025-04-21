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
            CloseForm = new Button();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // listBoxOrders
            // 
            listBoxOrders.FormattingEnabled = true;
            listBoxOrders.ItemHeight = 15;
            listBoxOrders.Location = new Point(30, 50);
            listBoxOrders.Name = "listBoxOrders";
            listBoxOrders.Size = new Size(1388, 769);
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
            labelQueue.Size = new Size(80, 15);
            labelQueue.TabIndex = 2;
            labelQueue.Text = "Orders Queue";
            // 
            // CloseForm
            // 
            CloseForm.Location = new Point(1436, 89);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(75, 23);
            CloseForm.TabIndex = 3;
            CloseForm.Text = "Close";
            CloseForm.UseVisualStyleBackColor = true;
            CloseForm.Click += CloseForm_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(1436, 60);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // KitchenForm
            // 
            ClientSize = new Size(1784, 924);
            Controls.Add(UpdateButton);
            Controls.Add(CloseForm);
            Controls.Add(labelQueue);
            Controls.Add(buttonServeNext);
            Controls.Add(listBoxOrders);
            Name = "KitchenForm";
            Text = "Kitchen Orders";
            Load += KitchenForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button CloseForm;
        private Button UpdateButton;
    }
}