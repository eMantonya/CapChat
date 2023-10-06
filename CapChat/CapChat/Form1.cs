namespace CapChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonRegisterScreen_Click(object sender, EventArgs e)
        {
            PanelRegister.Visible = true;
            
            PanelLogin.Visible = false;

            ButtonLoginScreen.BackColor = Color.SlateGray;
            ButtonRegisterScreen.BackColor = Color.SteelBlue;

            CheckMarkPass.Visible = false;
            CheckMarkConfirmPass.Visible = false;
            LabelFirstNameRequired.Visible = false;
            LabelLastNameRequired.Visible = false;
            LabelEmailRequired.Visible = false;
            LabelPassReqs.Visible = false;
            LabelConfirmPass.Visible = false;
            PanelRegister.BringToFront();
        }

        private void ButtonLoginScreen_Click(object sender, EventArgs e)
        {
            PanelLogin.Visible = true;
            PanelLogin.BringToFront();
            PanelRegister.Visible = false;
            ButtonLoginScreen.BackColor = Color.SteelBlue;
            ButtonRegisterScreen.BackColor = Color.SlateGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelLogin.Visible = true;
            PanelRegister.Visible = false;
            PanelLogin.BringToFront();
        }
    }
}