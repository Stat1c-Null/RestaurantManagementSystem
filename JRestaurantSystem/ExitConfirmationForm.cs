using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRestaurantSystem
{
    public partial class ExitConfirmationForm : Form
    {
        //The constructor initializes the form and its components
        public ExitConfirmationForm()
        {
            InitializeComponent();
        }
        //Event handler for the yes to close the form
        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        //Event handler for the yes to close the form
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}