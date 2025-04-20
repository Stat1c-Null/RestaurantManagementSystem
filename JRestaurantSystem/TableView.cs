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
    public partial class TableView : Form
    {
        public TableView(string TableName)
        {
            InitializeComponent();
            PageLabel.Text = TableName;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
