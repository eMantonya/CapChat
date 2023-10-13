using UserLibrary;

namespace CapChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelLogin.Visible = true;
            panelLogin.BringToFront();
        }

        private void buttonLoginScreen_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelLogin.Visible = true;
            panelLogin.BringToFront();
        }

        private void buttonRegisterScreen_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
            panelLogin.Visible = false;
            panelRegister.BringToFront();
            checkmarkPass.Visible = false;
            checkmarkConfirmPass.Visible = false;
            errorFirstName.Visible = false;
            errorLastName.Visible = false;
            errorEmail.Visible = false;
            errorPass.Visible = true;
            errorConfirmPass.Visible = false;
        }

        private void textBoxRegisterFName_LostFocus(object sender, EventArgs e)
        {
            errorFirstName.Visible = string.IsNullOrEmpty(textBoxRegisterFName.Text);
        }
        private void textBoxRegisterLName_LostFocus(object sender, EventArgs e)
        {
            errorLastName.Visible = string.IsNullOrEmpty(textBoxRegisterLName.Text);
        }
        private void textBoxRegisterEmail_LostFocus(object sender, EventArgs e)
        {
            errorEmail.Visible = string.IsNullOrEmpty(textBoxRegisterEmail.Text);
        }
        private void textBoxRegisterPass_LostFocus(object sender, EventArgs e)
        {
            string pass = textBoxRegisterPass.Text;
            if (pass.Length < 10)
            {
                errorPass.Visible = true;
            } else { errorPass.Visible = false; }
        }
        private void textBoxRegisterConfirmPass_LostFocus(object sender, EventArgs e)
        {
            string pass = textBoxRegisterPass.Text;
            string confirmPass = textBoxRegisterConfirmPass.Text;

            if (String.Compare(pass, confirmPass) != 0)
            {
                errorConfirmPass.Visible = true;
            }
            else { errorPass.Visible = false; }
        }

        private void buttonRegisterSubmit_Click(object sender, EventArgs e)
        {
            string first = textBoxRegisterFName.Text;
            string last = textBoxRegisterLName.Text;
            string email = textBoxRegisterEmail.Text;
            string password = textBoxRegisterPass.Text;
            try
            {
                User user = new User(first, last, email, password);
                return;
            }
            catch
            {
                textBoxRegisterFName_LostFocus(sender, e);
                textBoxRegisterLName_LostFocus(sender, e);
                textBoxRegisterEmail_LostFocus(sender, e);
                MessageBox.Show("Please correct any errors and try again", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}