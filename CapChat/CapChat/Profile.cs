using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using UserLibrary;

namespace CapChat
{
    public partial class Profile : Form
    {
        private User _currentUser;
        private HubConnection _hubConnection;
        
        public Profile(User currentUser)
        {
            InitializeComponent();
            
            _currentUser = currentUser;

            _hubConnection = new HubConnectionBuilder().WithUrl("http://localhost:7278/api/").Build();//change this url to the url of negotiate function once deployed/store in key vault

            try
            {
                _hubConnection.StartAsync();
                chatBox.Items.Add("Connected!");
            }
            catch (Exception ex)
            {
                chatBox.Items.Add($"{ex.Message}");
            }

            _hubConnection.On<string>("newMessage", (message) =>
            {
                UpdateChatBox(message);
            });
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            _hubConnection.StopAsync();
            Landing landing = new Landing();
            this.Hide();
            landing.Show();
        }

        private async void Profile_Load(object sender, EventArgs e)
        {
            Landing landing = new Landing();

            labelProfileGreeting.Text = "Hello";
            labelProfileName.Text = _currentUser.FirstName + " " + _currentUser.LastName;

            panelNavigation.Size = MinimumSize;
            panelNavigation.BackColor = Color.Transparent;

            buttonAccount.BackColor = Color.Transparent;
            buttonChat.BackColor = Color.Transparent;
            buttonLogout.BackColor = Color.Transparent;
            labelEditSuccess.Visible = false;
            panelChangePassword.Visible = false;
            panelChat.Visible = false;


            panelAccount.Visible = true;
            panelChangePassword.Visible = false;
            panelAccount.BringToFront();
            labelEditSuccess.Visible = false;
            labelFirstName.Text = _currentUser.FirstName;
            labelLastName.Text = _currentUser.LastName;
            labelEmail.Text = _currentUser.Email;
        }
        private async void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:7278/api/sendmessage/")) //url of azure 'sendmessage' function once redeployed
                    {
                        string body = $"{_currentUser.FirstName} -- {textBoxSend.Text}";
                        request.Content = new StringContent(JsonConvert.SerializeObject(body)/*, Encoding.UTF8, "application/json"*/);

                        HttpResponseMessage responseMessage = await httpClient.SendAsync(request).ConfigureAwait(false);

            });
            try
            {
                await _hubConnection.StartAsync();
                chatBox.Items.Add("Connected");
            }
            catch (Exception ex)
            {
                chatBox.Items.Add(ex.Message);
            }
        }

        //cross-thread exceptions were an issue when trying to update UI controls
        //Use of MethodInvoker relieves cross-threading
        private void UpdateChatBox(string text)
        {
            chatBox.Invoke((MethodInvoker)(() => chatBox.Items.Add(text)));
            textBoxSend.Invoke((MethodInvoker)(() => textBoxSend.Text = ""));
        }

        private void navToggle_Click(object sender, EventArgs e)
        {
            if (panelNavigation.Size == panelNavigation.MaximumSize)
            {
                while (panelNavigation.Size != panelNavigation.MinimumSize)
                {
                    panelNavigation.Width -= 5;
                }

                panelNavigation.Size = panelNavigation.MinimumSize;
                panelNavigation.BackColor = Color.Transparent;
                panelNavButtons.BackColor = Color.Transparent;
                buttonChat.BackColor = Color.Transparent;
                buttonAccount.BackColor = Color.Transparent;
                buttonLogout.BackColor = Color.Transparent;
                labelProfileName.Visible = false;
            }
            else
            {
                panelNavigation.Size = panelNavigation.MaximumSize;
                panelNavigation.BackColor = Color.SlateGray;
                panelNavButtons.BackColor = Color.SlateGray;
                buttonChat.BackColor = Color.SlateGray;
                buttonAccount.BackColor = Color.SlateGray;
                buttonLogout.BackColor = Color.SlateGray;
                labelProfileName.Visible = true;
                panelNavigation.BringToFront();
            }
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = true;
            panelChangePassword.Visible = false;
            panelChat.Visible = false;
            panelAccount.BringToFront();
            labelEditSuccess.Visible = false;
            labelFirstName.Text = _currentUser.FirstName;
            labelLastName.Text = _currentUser.LastName;
            labelEmail.Text = _currentUser.Email;
            navToggle_Click(this, e);
        }

        private void buttonSubmitEdit_Click(object sender, EventArgs e)
        {
            if (_currentUser.UpdateUserName(textBoxFirstNameUpdate.Text, textBoxLastNameUpdate.Text))
            {
                panelEditProfile.Visible = false;
                panelAccount.Visible = true;
                panelAccount.BringToFront();
                labelEditSuccess.Text = "Account updated";
                labelEditSuccess.Visible = true;
                labelFirstName.Text = _currentUser.FirstName;
                labelLastName.Text = _currentUser.LastName;
                labelProfileName.Text = _currentUser.FirstName + "  " + _currentUser.LastName;
            }
            else
            {
                panelEditProfile.Visible = false;
                panelAccount.Visible = true;
                panelAccount.BringToFront();
                labelEditSuccess.Visible = true;
                labelEditSuccess.Text = "Unsuccessful..";

            }
        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = false;
            panelEditProfile.Visible = true;
            textBoxFirstNameUpdate.Text = "";
            textBoxLastNameUpdate.Text = "";
            panelEditProfile.BringToFront();
        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            buttonAccount_Click(sender, e);
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = false;
            panelEditProfile.Visible = false;
            panelChangePassword.Visible = true;
            panelChangePassword.BringToFront();
            labelCurrentPass.Visible = false;
            labelNewPass.Visible = false;
            labelConfirmPass.Visible = false;
        }

        private void buttonChangePassConfirm_Click(object sender, EventArgs e)
        {
            string oldPass = textBoxCurrentPass.Text;
            string newPass = textBoxNewPass.Text;
            string confirmPass = textBoxConfirmPass.Text;
            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords must match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPass.Length < 10)
            {
                MessageBox.Show("Password must be at least 10 characters long", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!_currentUser.VerifyPassword(oldPass))
            {
                MessageBox.Show("Check password and try again", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_currentUser.UpdateUserPassword(newPass))
            {
                MessageBox.Show("Failed to update Password", "Internal Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            panelEditProfile.Visible = false;
            panelChangePassword.Visible = false;
            panelAccount.Visible = true;
            panelAccount.BringToFront();
            labelEditSuccess.Text = "Password Changed";
            labelEditSuccess.Visible = true;
        }

        private void textBoxCurrentPass_LostFocus(object sender, EventArgs e)
        {
            labelCurrentPass.Visible = (textBoxCurrentPass.Text.Length == 0);
        }

        private void textBoxNewPass_LostFocus(object sender, EventArgs e)
        {
            labelNewPass.Visible = (textBoxNewPass.Text.Length == 0);
        }

        private void textBoxConfirmPass_LostFocus(object sender, EventArgs e)
        {
            labelConfirmPass.Visible = (textBoxConfirmPass.Text != textBoxNewPass.Text);
        }

        private void buttonCancelPassChange_Click(object sender, EventArgs e)
        {
            buttonAccount_Click(sender, e);
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = false;
            panelChangePassword.Visible = false;
            panelEditProfile.Visible = false;

            panelChat.Visible = true;
            panelChat.BringToFront();
            navToggle_Click(sender, e);
        }
    }
}
