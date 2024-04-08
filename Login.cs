namespace ASM_2__off_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPass.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Username and Password is not Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username.Equals("vinh") && password.Equals("123"))
            {
                this.Hide();
                CaculateWaterBill waterBill = new CaculateWaterBill();
                waterBill.Show();
            }
            else
            {
                MessageBox.Show("Account Invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
