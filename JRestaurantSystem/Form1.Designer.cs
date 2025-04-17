namespace JRestaurantSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            LogOutButton = new Button();
            PageLabel = new Label();
            label2 = new Label();
            ServerName = new Label();
            panel2 = new Panel();
            AssignedTablesButton = new Button();
            label4 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(-3, 104);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 626);
            panel1.TabIndex = 0;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = SystemColors.Control;
            LogOutButton.Font = new Font("Segoe UI", 25F);
            LogOutButton.Location = new Point(1186, 775);
            LogOutButton.Margin = new Padding(4);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(279, 77);
            LogOutButton.TabIndex = 1;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = false;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Font = new Font("Segoe UI", 30F);
            PageLabel.ForeColor = SystemColors.ButtonFace;
            PageLabel.Location = new Point(15, 13);
            PageLabel.Margin = new Padding(4, 0, 4, 0);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(173, 71);
            PageLabel.TabIndex = 0;
            PageLabel.Text = "Home";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(1353, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 45);
            label2.TabIndex = 3;
            label2.Text = "Waiter";
            // 
            // ServerName
            // 
            ServerName.AutoSize = true;
            ServerName.Font = new Font("Segoe UI", 18F);
            ServerName.ForeColor = SystemColors.ButtonFace;
            ServerName.Location = new Point(1260, 13);
            ServerName.Margin = new Padding(4, 0, 4, 0);
            ServerName.Name = "ServerName";
            ServerName.Size = new Size(205, 45);
            ServerName.TabIndex = 4;
            ServerName.Text = "Ryan Gosling";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AssignedTablesButton);
            panel2.Location = new Point(747, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 626);
            panel2.TabIndex = 5;
            // 
            // AssignedTablesButton
            // 
            AssignedTablesButton.Font = new Font("Segoe UI", 25F);
            AssignedTablesButton.Location = new Point(209, 492);
            AssignedTablesButton.Name = "AssignedTablesButton";
            AssignedTablesButton.Size = new Size(378, 83);
            AssignedTablesButton.TabIndex = 0;
            AssignedTablesButton.Text = "Assigned Tables";
            AssignedTablesButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(251, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(268, 45);
            label4.TabIndex = 6;
            label4.Text = "Main Floor Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(251, 213);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 45);
            label5.TabIndex = 7;
            label5.Text = "Bar Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(1508, 879);
            Controls.Add(panel2);
            Controls.Add(LogOutButton);
            Controls.Add(ServerName);
            Controls.Add(label2);
            Controls.Add(PageLabel);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "J's Restaurant Managment System";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button LogOutButton;
        private Label PageLabel;
        private Label label2;
        private Label ServerName;
        private Panel panel2;
        private Button AssignedTablesButton;
        private Label label5;
        private Label label4;
    }
}
