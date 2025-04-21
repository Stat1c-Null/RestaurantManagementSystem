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

            /// TODO: send confirmedItems to your backend or persist them
        }

        /// <summary>
        /// Required method for Designer support  
        /// — do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            /// Header panel
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(21, 48, 74);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 100;

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Table X";
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(20, 60);
            this.lblInfo.Text = "#12345678    " + DateTime.Now.ToString("MM/dd/yy  hh:mm tt");
            this.pnlHeader.Controls.Add(this.lblInfo);

            this.lblEmp = new System.Windows.Forms.Label();
            this.lblEmp.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEmp.Width = 200;
            this.lblEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmp.ForeColor = System.Drawing.Color.White;
            this.lblEmp.Text = "Employee Name\nWaiter";
            this.lblEmp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.pnlHeader.Controls.Add(this.lblEmp);

            /// Sidebar
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 250;

            this.dgvOrder = new System.Windows.Forms.DataGridView();

            /// create columns
            var colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var colRemove = new System.Windows.Forms.DataGridViewButtonColumn();

            /// configure text column
            colItem.HeaderText = "Item";
            colItem.Name = "colItem";
            colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            /// configure remove‑button column
            colRemove.HeaderText = "";
            colRemove.Name = "colRemove";
            colRemove.Text = "✕";
            colRemove.UseColumnTextForButtonValue = true;
            colRemove.Width = 30;

            /// add columns and style the grid
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
    colItem, colRemove
});
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;

            /// finally add to sidebar
            this.pnlSidebar.Controls.Add(this.dgvOrder);

            /// Content area
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(21, 48, 74);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;

            /// Footer
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(8, 32, 62);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 100;


            /// Footer label
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;

            /// pick an X so it sits centered-ish in the footer
            this.lblTotal.Location = new System.Drawing.Point(400, 30);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Text = "Total: $0.00";
            this.pnlFooter.Controls.Add(this.lblTotal);

            /// Back button
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack.Size = new System.Drawing.Size(120, 60);
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Text = "BACK";
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(8, 32, 62);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.pnlFooter.Controls.Add(this.btnBack);

            /// Home button
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnHome.Size = new System.Drawing.Size(140, 60);
            this.btnHome.Location = new System.Drawing.Point(160, 20);
            this.btnHome.Text = "HOME";
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(8, 32, 62);
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.pnlFooter.Controls.Add(this.btnHome);

            ///Confirm Order Button
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnConfirmOrder.Size = new System.Drawing.Size(180, 60);

            this.btnConfirmOrder.Location = new System.Drawing.Point(this.ClientSize.Width - 340, 20);
            this.btnConfirmOrder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnConfirmOrder.Text = "CONFIRM ORDER";
            this.btnConfirmOrder.BackColor = System.Drawing.Color.White;
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.FromArgb(8, 32, 62);
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            this.pnlFooter.Controls.Add(this.btnConfirmOrder);

            /// Form
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Text = "Restaurant Order System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
