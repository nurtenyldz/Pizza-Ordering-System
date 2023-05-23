namespace Pizza_Ordering__System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else if (UnameTb.Text == "User" && PasswordTb.Text == "Pass")
            {
                Billing Obj = new Billing();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Data!!!");
            }
        }

    }
}