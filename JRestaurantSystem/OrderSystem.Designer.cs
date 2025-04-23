using JRestaurantSystem;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Tsunami
{
    partial class OrderSystem
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblEmp;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.DataGridView dgvOrder;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirmOrder;



        /// <summary> 
        /// Clean up any resources being used. 
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Fired when the “CONFIRM ORDER” button is clicked.
        /// Grabs every item text from the grid and stores them in confirmedItems.
        /// </summary>
        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            /// Pull the “Item” column from every row into a string[]
            confirmedItems = dgvOrder.Rows
                .OfType<DataGridViewRow>()
                .Select(r => r.Cells["colItem"].Value?.ToString() ?? "")
                .Where(s => !string.IsNullOrEmpty(s))
                .ToArray();

            MessageBox.Show(
                $"You have confirmed {confirmedItems.Length} item(s).",
                "Order Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            /// Send order to the kitchen
            string tableNumber = lblTitle.Text;

            string waiterName = lblEmp.Text;

            List<string> selectedItems = new List<string>();
            selectedItems.AddRange(confirmedItems);

            Order newOrder = new Order(tableNumber, waiterName, selectedItems);
            kitchenForm.OrderQueue.Enqueue(newOrder);
        }

        /// <summary>
        /// Required method for Designer support  
        /// — do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblInfo = new Label();
            lblEmp = new Label();
            pnlSidebar = new Panel();
            dgvOrder = new DataGridView();
            colItem = new DataGridViewTextBoxColumn();
            colRemove = new DataGridViewButtonColumn();
            pnlContent = new Panel();
            pnlFooter = new Panel();
            CloseButton = new Button();
            lblTotal = new Label();
            btnBack = new Button();
            btnHome = new Button();
            btnConfirmOrder = new Button();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            ((ISupportInitialize)dgvOrder).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(21, 48, 74);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblInfo);
            pnlHeader.Controls.Add(lblEmp);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 100);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(152, 51);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Table X";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 10F);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(20, 60);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(198, 19);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "#12345678    04.21.25  01:46 ";
            // 
            // lblEmp
            // 
            lblEmp.Dock = DockStyle.Right;
            lblEmp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmp.ForeColor = Color.White;
            lblEmp.Location = new Point(972, 0);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(228, 100);
            lblEmp.TabIndex = 2;
            lblEmp.Text = "Employee Name";
            lblEmp.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(52, 152, 219);
            pnlSidebar.Controls.Add(dgvOrder);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 100);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 600);
            pnlSidebar.TabIndex = 1;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.BackgroundColor = Color.White;
            dgvOrder.BorderStyle = BorderStyle.None;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { colItem, colRemove });
            dgvOrder.Dock = DockStyle.Fill;
            dgvOrder.Location = new Point(0, 0);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.Size = new Size(250, 600);
            dgvOrder.TabIndex = 0;
            // 
            // colItem
            // 
            colItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colItem.HeaderText = "Item";
            colItem.Name = "colItem";
            // 
            // colRemove
            // 
            colRemove.HeaderText = "";
            colRemove.Name = "colRemove";
            colRemove.Text = "✕";
            colRemove.UseColumnTextForButtonValue = true;
            colRemove.Width = 30;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(21, 48, 74);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(250, 100);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(950, 600);
            pnlContent.TabIndex = 0;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(8, 32, 62);
            pnlFooter.Controls.Add(CloseButton);
            pnlFooter.Controls.Add(lblTotal);
            pnlFooter.Controls.Add(btnBack);
            pnlFooter.Controls.Add(btnHome);
            pnlFooter.Controls.Add(btnConfirmOrder);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 700);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1200, 100);
            pnlFooter.TabIndex = 2;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.White;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            CloseButton.ForeColor = Color.FromArgb(8, 32, 62);
            CloseButton.Location = new Point(323, 20);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(140, 60);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "CLOSE";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(497, 20);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(134, 30);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total: $0.00";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(8, 32, 62);
            btnBack.Location = new Point(20, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 60);
            btnBack.TabIndex = 1;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(8, 32, 62);
            btnHome.Location = new Point(160, 20);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(140, 60);
            btnHome.TabIndex = 2;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmOrder.BackColor = Color.White;
            btnConfirmOrder.FlatStyle = FlatStyle.Flat;
            btnConfirmOrder.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnConfirmOrder.ForeColor = Color.FromArgb(8, 32, 62);
            btnConfirmOrder.Location = new Point(972, 20);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(180, 60);
            btnConfirmOrder.TabIndex = 3;
            btnConfirmOrder.Text = "CONFIRM ORDER";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // OrderSystem
            // 
            ClientSize = new Size(1200, 800);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Name = "OrderSystem";
            Text = "Restaurant Order System";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            ((ISupportInitialize)dgvOrder).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn colItem;
        private DataGridViewButtonColumn colRemove;
        private Button CloseButton;
    }
}