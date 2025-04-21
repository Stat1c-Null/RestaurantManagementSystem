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
            SaveButton = new Button();
            SeatSelector = new ComboBox();
            StatusSelector = new ComboBox();
            StatusLabel = new Label();
            createOrderButton = new Button();
            viewOrderButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            NorthSeatButton = new Button();
            EastSeatButton = new Button();
            SouthSeatButton = new Button();
            WestSeatButton = new Button();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            BackButton.Location = new Point(11, 414);
            BackButton.Margin = new Padding(2);
            BackButton.Name = "BackButton";
            BackButton.Padding = new Padding(23, 0, 23, 0);
            BackButton.Size = new Size(162, 55);
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
            PageLabel.Location = new Point(-4, -1);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(123, 54);
            PageLabel.TabIndex = 2;
            PageLabel.Text = "Table";
            PageLabel.Click += PageLabel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(43, 75, 120);
            panel2.Controls.Add(SaveButton);
            panel2.Controls.Add(SeatSelector);
            panel2.Controls.Add(StatusSelector);
            panel2.Controls.Add(StatusLabel);
            panel2.Controls.Add(createOrderButton);
            panel2.Controls.Add(viewOrderButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(387, -1);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 483);
            panel2.TabIndex = 6;
            // 
            // SaveButton
            // 
            SaveButton.AutoSize = true;
            SaveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatAppearance.BorderColor = Color.FromArgb(113, 155, 191);
            SaveButton.FlatAppearance.BorderSize = 20;
            SaveButton.Font = new Font("Segoe UI", 21.8879986F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.MidnightBlue;
            SaveButton.Location = new Point(63, 415);
            SaveButton.Margin = new Padding(2);
            SaveButton.Name = "SaveButton";
            SaveButton.Padding = new Padding(6, 0, 6, 0);
            SaveButton.Size = new Size(112, 51);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "SAVE";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SeatSelector
            // 
            SeatSelector.AllowDrop = true;
            SeatSelector.FormattingEnabled = true;
            SeatSelector.Items.AddRange(new object[] { "NORTH SEAT", "EAST SEAT", "SOUTH SEAT", "WEST SEAT" });
            SeatSelector.Location = new Point(39, 74);
            SeatSelector.Name = "SeatSelector";
            SeatSelector.Size = new Size(164, 23);
            SeatSelector.TabIndex = 14;
            SeatSelector.Text = "Select Seat...";
            // 
            // StatusSelector
            // 
            StatusSelector.AllowDrop = true;
            StatusSelector.FormattingEnabled = true;
            StatusSelector.Items.AddRange(new object[] { "OCCUPIED", "OPEN", "DIRTY" });
            StatusSelector.Location = new Point(39, 353);
            StatusSelector.Name = "StatusSelector";
            StatusSelector.Size = new Size(164, 23);
            StatusSelector.TabIndex = 13;
            StatusSelector.Text = "Set Status...";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.BackColor = Color.White;
            StatusLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = SystemColors.ActiveCaptionText;
            StatusLabel.Location = new Point(39, 207);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new Padding(30, 0, 30, 0);
            StatusLabel.Size = new Size(123, 25);
            StatusLabel.TabIndex = 12;
            StatusLabel.Text = "OPEN";
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
            createOrderButton.Location = new Point(271, 415);
            createOrderButton.Margin = new Padding(2);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Padding = new Padding(6, 0, 6, 0);
            createOrderButton.Size = new Size(257, 51);
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
            viewOrderButton.Location = new Point(271, 331);
            viewOrderButton.Margin = new Padding(2);
            viewOrderButton.Name = "viewOrderButton";
            viewOrderButton.Padding = new Padding(23, 0, 23, 0);
            viewOrderButton.Size = new Size(260, 51);
            viewOrderButton.TabIndex = 7;
            viewOrderButton.Text = "VIEW ORDER";
            viewOrderButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(26, 305);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 10;
            label3.Text = "Updated Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(26, 156);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 9;
            label2.Text = "Current Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.855999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 8;
            label1.Text = "Seats";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(117, 160, 195);
            panel1.Controls.Add(NorthSeatButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(WestSeatButton);
            panel1.Controls.Add(SouthSeatButton);
            panel1.Controls.Add(EastSeatButton);
            panel1.Location = new Point(-4, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 339);
            panel1.TabIndex = 7;
            // 
            // NorthSeatButton
            // 
            NorthSeatButton.BackColor = Color.FromArgb(171, 213, 247);
            NorthSeatButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NorthSeatButton.Location = new Point(166, 17);
            NorthSeatButton.Margin = new Padding(2);
            NorthSeatButton.Name = "NorthSeatButton";
            NorthSeatButton.Size = new Size(48, 45);
            NorthSeatButton.TabIndex = 45;
            NorthSeatButton.Text = "N";
            NorthSeatButton.UseVisualStyleBackColor = false;
            // 
            // EastSeatButton
            // 
            EastSeatButton.BackColor = Color.FromArgb(171, 213, 247);
            EastSeatButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EastSeatButton.Location = new Point(299, 141);
            EastSeatButton.Margin = new Padding(2);
            EastSeatButton.Name = "EastSeatButton";
            EastSeatButton.Size = new Size(48, 45);
            EastSeatButton.TabIndex = 46;
            EastSeatButton.Text = "E";
            EastSeatButton.UseVisualStyleBackColor = false;
            // 
            // SouthSeatButton
            // 
            SouthSeatButton.BackColor = Color.FromArgb(171, 213, 247);
            SouthSeatButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SouthSeatButton.Location = new Point(166, 274);
            SouthSeatButton.Margin = new Padding(2);
            SouthSeatButton.Name = "SouthSeatButton";
            SouthSeatButton.Size = new Size(48, 45);
            SouthSeatButton.TabIndex = 47;
            SouthSeatButton.Text = "S";
            SouthSeatButton.UseVisualStyleBackColor = false;
            // 
            // WestSeatButton
            // 
            WestSeatButton.BackColor = Color.FromArgb(171, 213, 247);
            WestSeatButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WestSeatButton.Location = new Point(33, 141);
            WestSeatButton.Margin = new Padding(2);
            WestSeatButton.Name = "WestSeatButton";
            WestSeatButton.Size = new Size(48, 45);
            WestSeatButton.TabIndex = 48;
            WestSeatButton.Text = "W";
            WestSeatButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 75, 120);
            panel3.Location = new Point(116, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(148, 138);
            panel3.TabIndex = 0;
            // 
            // TableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(13, 32, 81);
            ClientSize = new Size(921, 484);
            Controls.Add(BackButton);
            Controls.Add(PageLabel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "TableView";
            Text = "TableView";
            Load += TableView_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Label StatusLabel;
        private ComboBox StatusSelector;
        private ComboBox SeatSelector;
        private Panel panel1;
        private Button NorthSeatButton;
        private Button EastSeatButton;
        private Button SouthSeatButton;
        private Button WestSeatButton;
        private Button SaveButton;
        private Panel panel3;
    }
}