namespace JRestaurantSystem
{
    partial class LoginForm
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
            topPanel = new PictureBox();
            centerPanel = new PictureBox();
            bottomPanel = new PictureBox();
            secondPanel = new PictureBox();
            forthPanel = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtPin = new TextBox();
            panel1 = new Panel();
            logButton = new Button();
            exitButton = new Button();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)topPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)centerPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottomPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forthPanel).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(13, 32, 81);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 62);
            topPanel.TabIndex = 0;
            topPanel.TabStop = false;
            // 
            // centerPanel
            // 
            centerPanel.BackColor = Color.FromArgb(117, 160, 195);
            centerPanel.Location = new Point(0, 68);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(800, 314);
            centerPanel.TabIndex = 1;
            centerPanel.TabStop = false;
            centerPanel.Click += pictureBox2_Click;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(13, 32, 81);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 388);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(800, 62);
            bottomPanel.TabIndex = 2;
            bottomPanel.TabStop = false;
            // 
            // secondPanel
            // 
            secondPanel.BackColor = Color.FromArgb(170, 213, 247);
            secondPanel.Dock = DockStyle.Top;
            secondPanel.Location = new Point(0, 62);
            secondPanel.Name = "secondPanel";
            secondPanel.Size = new Size(800, 8);
            secondPanel.TabIndex = 3;
            secondPanel.TabStop = false;
            // 
            // forthPanel
            // 
            forthPanel.BackColor = Color.FromArgb(170, 213, 247);
            forthPanel.Dock = DockStyle.Bottom;
            forthPanel.Location = new Point(0, 380);
            forthPanel.Name = "forthPanel";
            forthPanel.Size = new Size(800, 8);
            forthPanel.TabIndex = 4;
            forthPanel.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(13, 32, 81);
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 36);
            label1.TabIndex = 5;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(117, 160, 195);
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(13, 32, 81);
            label2.Location = new Point(244, 166);
            label2.Name = "label2";
            label2.Size = new Size(222, 22);
            label2.TabIndex = 6;
            label2.Text = "Employee PIN Number:";
            label2.Click += label2_Click;
            // 
            // txtPin
            // 
            txtPin.BorderStyle = BorderStyle.None;
            txtPin.Dock = DockStyle.Fill;
            txtPin.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            txtPin.ForeColor = Color.Gray;
            txtPin.Location = new Point(4, 4);
            txtPin.Multiline = true;
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(301, 42);
            txtPin.TabIndex = 7;
            txtPin.Text = "Enter PIN...\r\n";
            txtPin.TextChanged += textBox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 32, 81);
            panel1.Controls.Add(txtPin);
            panel1.Location = new Point(244, 200);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(309, 50);
            panel1.TabIndex = 8;
            // 
            // logButton
            // 
            logButton.BackColor = Color.FromArgb(43, 75, 120);
            logButton.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logButton.ForeColor = Color.White;
            logButton.Location = new Point(326, 273);
            logButton.Name = "logButton";
            logButton.Size = new Size(150, 50);
            logButton.TabIndex = 9;
            logButton.Text = "LOGIN";
            logButton.UseVisualStyleBackColor = false;
            logButton.Click += logButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.White;
            exitButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.FromArgb(13, 32, 81);
            exitButton.Location = new Point(650, 396);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(138, 44);
            exitButton.TabIndex = 10;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(117, 160, 195);
            lblResult.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(23, 349);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(727, 28);
            lblResult.TabIndex = 11;
            lblResult.Text = "Result";
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(exitButton);
            Controls.Add(logButton);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(forthPanel);
            Controls.Add(secondPanel);
            Controls.Add(bottomPanel);
            Controls.Add(centerPanel);
            Controls.Add(topPanel);


            Name = "Form1";
            Text = "Form1";


            ((System.ComponentModel.ISupportInitialize)topPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)centerPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottomPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)forthPanel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox topPanel;
        private PictureBox centerPanel;
        private PictureBox bottomPanel;
        private PictureBox secondPanel;
        private PictureBox forthPanel;
        private Label label1;
        private Label label2;
        private TextBox txtPin;
        private Panel panel1;
        private Button logButton;
        private Button exitButton;
        private Label lblResult;

    }
}
