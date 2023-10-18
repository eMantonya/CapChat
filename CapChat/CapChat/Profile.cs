using CapChat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLibrary;

namespace CapChat
{
    public partial class Profile : Form
    {
        private User _currentUser;
        public Profile(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            this.Hide();
            landing.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Landing landing = new Landing();

            labelProfileGreeting.Text = "Hello";
            labelProfileName.Text = _currentUser.FirstName + " " + _currentUser.LastName;

            panelNavigation.Size = MinimumSize;
            panelNavigation.BackColor = Color.Transparent;
            buttonHome.BackColor = Color.Transparent;
            buttonAccount.BackColor = Color.Transparent;
            buttonChat.BackColor = Color.Transparent;
            buttonLogout.BackColor = Color.Transparent;
            panelHome.Visible = false;
            buttonAccount_Click(sender, e);

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
                buttonHome.BackColor = Color.Transparent;
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
                buttonHome.BackColor = Color.SlateGray;
                buttonChat.BackColor = Color.SlateGray;
                buttonAccount.BackColor = Color.SlateGray;
                buttonLogout.BackColor = Color.SlateGray;
                labelProfileName.Visible = true;
                panelNavigation.BringToFront();
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            //panelAccount.Visible = false;
            //panelChat.Visible = false;
            //panelSettings.Visible = false;
            //panelHelp.Visible = false;
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            panelAccount.Visible = true;
            panelAccount.BringToFront();
            labelFirstName.Text = _currentUser.FirstName;
            labelLastName.Text = _currentUser.LastName;
            labelEmail.Text = _currentUser.Email;
        }
    }
}
