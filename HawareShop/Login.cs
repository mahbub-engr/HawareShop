namespace HawareShop
{
    public partial class Login : Form
    {
        private string Username = "admin";
        private string Password = "admin";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            if (txt_username.Text == Username && txt_password.Text == Password)
            {
                items.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
