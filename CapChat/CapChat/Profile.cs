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
        }

    }
}
