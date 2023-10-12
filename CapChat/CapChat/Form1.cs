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
            if (textBoxRegisterFName.Text.Length == 0) { errorFirstName.Visible = true; }
        }
        private void textBoxRegisterLName_LostFocus(object sender, EventArgs e)
        {
            if (textBoxRegisterLName.Text.Length == 0) { errorLastName.Visible = true; }
        }
        private void textBoxRegisterEmail_LostFocus(object sender, EventArgs e)
        {
            if (textBoxRegisterEmail.Text.Length == 0) { errorEmail.Visible = true; }
        }
    }
}