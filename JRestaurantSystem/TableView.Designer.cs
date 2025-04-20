namespace JRestaurantSystem
{
    partial class TableView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BackButton = new Button();
            PageLabel = new Label();
            panel2 = new Panel();
            createOrderButton = new Button();
            viewOrderButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatAppearance.BorderColor = Color.FromArgb(113, 155, 191);
            BackButton.FlatAppearance.BorderSize = 20;
            BackButton.Font = new Font("Segoe UI", 24.192F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.MidnightBlue;
            BackButton.Location = new Point(12, 599);
            BackButton.Name = "BackButton";
            BackButton.Padding = new Padding(30, 0, 30, 0);
            BackButton.Size = new Size(204, 67);
            BackButton.TabIndex = 1;
            BackButton.Text = "BACK";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Font = new Font("Segoe UI", 29.952F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PageLabel.ForeColor = SystemColors.ButtonFace;
            PageLabel.Location = new Point(12, 9);
            PageLabel.Margin = new Padding(4, 0, 4, 0);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(159, 70);
            PageLabel.TabIndex = 2;
            PageLabel.Text = "Table";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(43, 75, 120);
            panel2.Controls.Add(createOrderButton);
            panel2.Controls.Add(viewOrderButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(498, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 676);
            panel2.TabIndex = 6;
            // 
            // createOrderButton
            // 
            createOrderButton.AutoSize = true;
            createOrderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            createOrderButton.Cursor = Cursors.Hand;
            createOrderButton.FlatAppearance.BorderColor = Color.FromArgb(113, 155, 191);
            createOrderButton.FlatAppearance.BorderSize = 20;
            createOrderButton.Font = new Font("Segoe UI", 21.8879986F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createOrderButton.ForeColor = Color.MidnightBlue;
            createOrderButton.Location = new Point(349, 581);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Padding = new Padding(8, 0, 8, 0);
            createOrderButton.Size = new Size(321, 61);
            createOrderButton.TabIndex = 11;
            createOrderButton.Text = "CREATE ORDER";
            createOrderButton.UseVisualStyleBackColor = true;
            // 
            // viewOrderButton
            // 
            viewOrderButton.AutoSize = true;
            viewOrderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewOrderButton.Cursor = Cursors.Hand;
            viewOrderButton.FlatAppearance.BorderColor = Color.FromArgb(113, 155, 191);
            viewOrderButton.FlatAppearance.BorderSize = 20;
            viewOrderButton.Font = new Font("Segoe UI", 21.8879986F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewOrderButton.ForeColor = Color.MidnightBlue;
            viewOrderButton.Location = new Point(349, 463);
            viewOrderButton.Name = "viewOrderButton";
            viewOrderButton.Padding = new Padding(30, 0, 30, 0);
            viewOrderButton.Size = new Size(325, 61);
            viewOrderButton.TabIndex = 7;
            viewOrderButton.Text = "VIEW ORDER";
            viewOrderButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(33, 428);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(242, 42);
            label3.TabIndex = 10;
            label3.Text = "Updated Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(33, 220);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(227, 42);
            label2.TabIndex = 9;
            label2.Text = "Current Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(33, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 42);
            label1.TabIndex = 8;
            label1.Text = "Seats";
            // 
            // TableView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(13, 32, 81);
            ClientSize = new Size(1184, 678);
            Controls.Add(panel2);
            Controls.Add(PageLabel);
            Controls.Add(BackButton);
            Name = "TableView";
            Text = "TableView";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label PageLabel;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button createOrderButton;
        private Button viewOrderButton;
    }
}