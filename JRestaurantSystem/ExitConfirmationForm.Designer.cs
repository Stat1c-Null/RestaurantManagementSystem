namespace JRestaurantSystem
{
    partial class ExitConfirmationForm
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
            topPanel = new Panel();
            btnYes = new Button();
            btnNo = new Button();
            logOutLbl = new Label();
            lblConfirm = new Label();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(13, 32, 81);
            topPanel.Controls.Add(logOutLbl);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(568, 50);
            topPanel.TabIndex = 0;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(43, 75, 120);
            btnYes.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnYes.ForeColor = Color.White;
            btnYes.Location = new Point(24, 196);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(179, 55);
            btnYes.TabIndex = 1;
            btnYes.Text = "YES";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(170, 213, 247);
            btnNo.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnNo.ForeColor = Color.FromArgb(13, 32, 81);
            btnNo.Location = new Point(352, 196);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(179, 55);
            btnNo.TabIndex = 2;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // logOutLbl
            // 
            logOutLbl.AutoSize = true;
            logOutLbl.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logOutLbl.ForeColor = Color.White;
            logOutLbl.Location = new Point(24, 9);
            logOutLbl.Name = "logOutLbl";
            logOutLbl.Size = new Size(116, 28);
            logOutLbl.TabIndex = 0;
            logOutLbl.Text = "LOG OUT";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblConfirm.ForeColor = Color.FromArgb(13, 32, 81);
            lblConfirm.Location = new Point(24, 81);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(261, 21);
            lblConfirm.TabIndex = 3;
            lblConfirm.Text = "Are you sure you want to log out?";
            // 
            // ExitConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 277);
            Controls.Add(lblConfirm);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(topPanel);

            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            Name = "ExitConfirmationForm";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private Button btnYes;
        private Label logOutLbl;
        private Button btnNo;
        private Label lblConfirm;
    }
}