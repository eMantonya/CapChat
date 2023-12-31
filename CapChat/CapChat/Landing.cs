using UserLibrary;

namespace CapChat
{
    public partial class Landing : Form
    {
        public User? CurrentUser { get; set; }
        public Landing()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelLogin.Visible = true;
            labelLoginEmail.Visible = false;
            labelLoginPass.Visible = false;
            panelLogin.BringToFront();
        }

        private void buttonLoginScreen_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelLogin.Visible = true;
            labelLoginEmail.Visible = false;
            labelLoginPass.Visible = false;
            textBoxLoginEmail.Text = "";
            textBoxLoginPass.Text = "";
            panelLogin.BringToFront();
            buttonLoginScreen.BackColor = Color.DeepSkyBlue;
            buttonRegisterScreen.BackColor = Color.SlateGray;
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
            labelRegisterSuccess.Text = "";
            labelRegisterSuccess2.Text = "";
            buttonRegisterScreen.BackColor = Color.DeepSkyBlue;
            buttonLoginScreen.BackColor = Color.SlateGray;
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

            if (string.IsNullOrEmpty(textBoxRegisterEmail.Text))
            {
                errorEmail.Text = "Required";
                errorEmail.Visible = true;
            }
            else if (DbHelper.UserExists(textBoxRegisterEmail.Text))
            {
                errorEmail.Text = "Account with given email already created..";
                errorEmail.Visible = true;
            }
            else { errorEmail.Visible = false; }


        }
        private void textBoxRegisterPass_LostFocus(object sender, EventArgs e)
        {
            errorPass.Visible = textBoxRegisterPass.Text.Length < 10;
        }
        private void textBoxRegisterConfirmPass_LostFocus(object sender, EventArgs e)
        {
            errorConfirmPass.Visible = string.Compare(textBoxRegisterPass.Text, textBoxRegisterConfirmPass.Text) != 0;
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
                if (user.Stored == false)
                {
                    throw new ApplicationException();
                }
                labelRegisterSuccess.Text = "Register Success";
                labelRegisterSuccess2.Text = "Please login";
                buttonLoginScreen_Click(sender, e);
            }
            catch (ApplicationException)
            {
                MessageBox.Show("Failed to register user.. Please try again", "Internal Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonRegisterScreen_Click(sender, e);
            }
            catch (Exception)
            {
                textBoxRegisterFName_LostFocus(sender, e);
                textBoxRegisterLName_LostFocus(sender, e);
                textBoxRegisterEmail_LostFocus(sender, e);
                MessageBox.Show("Please correct any errors and try again", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxRegisterFName.Text = "";
                textBoxRegisterLName.Text = "";
                textBoxRegisterEmail.Text = "";
                textBoxRegisterPass.Text = "";
                textBoxRegisterConfirmPass.Text = "";
            }
        }

        private void textBoxRegisterPass_TextChanged(object sender, EventArgs e)
        {
            checkmarkPass.Visible = textBoxRegisterPass.Text.Length >= 10;
        }

        private void textBoxRegisterConfirmPass_TextChanged(object sender, EventArgs e)
        {
            checkmarkConfirmPass.Visible = string.Compare(textBoxRegisterPass.Text, textBoxRegisterConfirmPass.Text) == 0;
        }

        private void buttonLoginConfirm_Click(object sender, EventArgs e)
        {
            //validate email input and pass input
            string email = textBoxLoginEmail.Text;
            string pass = textBoxLoginPass.Text;
            //get user info by searching email. make email a unique field
            try
            {
                CurrentUser = DbHelper.RetrieveUser(email, pass);
                if (CurrentUser is null)
                {
                    labelRegisterSuccess.ForeColor = Color.Red;
                    labelRegisterSuccess.Text = "   Login failed..";
                }
                else
                {
                    Profile profile = new Profile(CurrentUser);
                    this.Hide();
                    profile.Show();
                }
            }
            catch
            {
                MessageBox.Show("Login failed.. Please try again", "Internal Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBoxLoginEmail_LostFocus(object sender, EventArgs e)
        {
            labelLoginEmail.Visible = textBoxLoginEmail.Text.Length == 0;
        }

        private void textBoxLoginPass_LostFocus(object sender, EventArgs e)
        {
            labelLoginPass.Visible = textBoxLoginPass.Text.Length == 0;
        }
    }
}