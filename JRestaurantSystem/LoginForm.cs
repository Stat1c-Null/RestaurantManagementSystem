namespace JRestaurantSystem
{
    public partial class LoginForm : Form
    {

        private Login loginManager;
        public LoginForm()
        {
            InitializeComponent();
            loginManager = new Login();

            //Check
            if (!loginManager.WaitersFileExists())
            {
                lblResult.Text = "Error: file not found.";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (txtPin.Text == "Enter PIN..." || string.IsNullOrEmpty(txtPin.Text))
            {
                txtPin.PasswordChar = '\0';
            }
            else
            {
                txtPin.PasswordChar = '*';
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //create and show the exit confirmation dialog
            using (ExitConfirmationForm confirmForm = new ExitConfirmationForm())
            {
                //show the dialog and get the result
                DialogResult result = confirmForm.ShowDialog(this);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            if (string.IsNullOrEmpty(txtPin.Text))
            {
                lblResult.Text = "Please emter PIN";
                return;
            }

            if (int.TryParse(txtPin.Text, out int pin))
            {
                bool loginSuccess = loginManager.logIn(pin);

                if (loginSuccess)
                {
                    Waiter loggedInWaiter = loginManager.GetCurrentWaiter();
                    lblResult.Text = $"Correct! Welcome {loggedInWaiter.Name}";
                    RestaurantMap restaurantMap = new RestaurantMap(loggedInWaiter);
                    restaurantMap.Show();
                    this.Hide();
                }
                else
                {
                    lblResult.Text = "Wrong PIN";
                    txtPin.Clear();
                    txtPin.Focus();
                }
            }
            else
            {
                lblResult.Text = "PIN must be numeric";
                txtPin.Clear();
                txtPin.Focus();
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
