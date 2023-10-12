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
    }
}