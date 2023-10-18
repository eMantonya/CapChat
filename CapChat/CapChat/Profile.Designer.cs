namespace CapChat
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            buttonLogout = new Button();
            labelProfileGreeting = new Label();
            panelNavigation = new Panel();
            labelProfileName = new Label();
            panelNavButtons = new Panel();
            buttonAccount = new Button();
            buttonHome = new Button();
            buttonChat = new Button();
            navToggle = new PictureBox();
            panelHome = new Panel();
            label1 = new Label();
            panelAccount = new Panel();
            buttonChangePassword = new Button();
            buttonEditAccount = new Button();
            labelLastName = new Label();
            labelEmail = new Label();
            labelFirstName = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelEditProfile = new Panel();
            buttonSubmitEdit = new Button();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            textBoxFirstNameUpdate = new TextBox();
            textBoxLastNameUpdate = new TextBox();
            buttonCancelEdit = new Button();
            panelNavigation.SuspendLayout();
            panelNavButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)navToggle).BeginInit();
            panelHome.SuspendLayout();
            panelAccount.SuspendLayout();
            panelEditProfile.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.SlateGray;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.LightSkyBlue;
            buttonLogout.Location = new Point(0, 208);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(173, 41);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // labelProfileGreeting
            // 
            labelProfileGreeting.AutoSize = true;
            labelProfileGreeting.BackColor = Color.Transparent;
            labelProfileGreeting.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelProfileGreeting.ForeColor = Color.LightSkyBlue;
            labelProfileGreeting.Location = new Point(51, 80);
            labelProfileGreeting.Name = "labelProfileGreeting";
            labelProfileGreeting.Size = new Size(74, 32);
            labelProfileGreeting.TabIndex = 1;
            labelProfileGreeting.Text = "Hello";
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.SlateGray;
            panelNavigation.Controls.Add(labelProfileName);
            panelNavigation.Controls.Add(panelNavButtons);
            panelNavigation.Controls.Add(labelProfileGreeting);
            panelNavigation.Controls.Add(navToggle);
            panelNavigation.Location = new Point(0, 0);
            panelNavigation.MaximumSize = new Size(177, 462);
            panelNavigation.MinimumSize = new Size(50, 462);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(177, 462);
            panelNavigation.TabIndex = 2;
            // 
            // labelProfileName
            // 
            labelProfileName.AutoSize = true;
            labelProfileName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelProfileName.ForeColor = Color.LightSkyBlue;
            labelProfileName.Location = new Point(90, 9);
            labelProfileName.Name = "labelProfileName";
            labelProfileName.Size = new Size(87, 21);
            labelProfileName.TabIndex = 6;
            labelProfileName.Text = "{first, last}";
            // 
            // panelNavButtons
            // 
            panelNavButtons.Controls.Add(buttonAccount);
            panelNavButtons.Controls.Add(buttonHome);
            panelNavButtons.Controls.Add(buttonLogout);
            panelNavButtons.Controls.Add(buttonChat);
            panelNavButtons.Location = new Point(0, 200);
            panelNavButtons.Name = "panelNavButtons";
            panelNavButtons.Size = new Size(177, 262);
            panelNavButtons.TabIndex = 5;
            // 
            // buttonAccount
            // 
            buttonAccount.BackColor = Color.SlateGray;
            buttonAccount.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAccount.Cursor = Cursors.Hand;
            buttonAccount.FlatAppearance.BorderColor = Color.SlateGray;
            buttonAccount.FlatAppearance.BorderSize = 0;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAccount.ForeColor = Color.LightSkyBlue;
            buttonAccount.Location = new Point(0, 48);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(173, 41);
            buttonAccount.TabIndex = 5;
            buttonAccount.Text = "Account";
            buttonAccount.UseVisualStyleBackColor = false;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.SlateGray;
            buttonHome.BackgroundImageLayout = ImageLayout.Stretch;
            buttonHome.Cursor = Cursors.Hand;
            buttonHome.FlatAppearance.BorderColor = Color.SlateGray;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHome.ForeColor = Color.LightSkyBlue;
            buttonHome.Location = new Point(0, 8);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(173, 41);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonChat
            // 
            buttonChat.BackColor = Color.SlateGray;
            buttonChat.Cursor = Cursors.Hand;
            buttonChat.FlatAppearance.BorderColor = Color.SlateGray;
            buttonChat.FlatAppearance.BorderSize = 0;
            buttonChat.FlatStyle = FlatStyle.Flat;
            buttonChat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChat.ForeColor = Color.LightSkyBlue;
            buttonChat.Location = new Point(0, 88);
            buttonChat.Name = "buttonChat";
            buttonChat.Size = new Size(173, 41);
            buttonChat.TabIndex = 2;
            buttonChat.Text = "Chat";
            buttonChat.UseVisualStyleBackColor = false;
            // 
            // navToggle
            // 
            navToggle.BackgroundImage = ClientGUI.Properties.Resources.hamburger;
            navToggle.BackgroundImageLayout = ImageLayout.Stretch;
            navToggle.Cursor = Cursors.Hand;
            navToggle.Location = new Point(6, 6);
            navToggle.Name = "navToggle";
            navToggle.Size = new Size(39, 36);
            navToggle.TabIndex = 0;
            navToggle.TabStop = false;
            navToggle.Click += navToggle_Click;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.Transparent;
            panelHome.Controls.Add(label1);
            panelHome.Location = new Point(183, 33);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(597, 426);
            panelHome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Location = new Point(286, 25);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // panelAccount
            // 
            panelAccount.BackColor = Color.Transparent;
            panelAccount.Controls.Add(buttonChangePassword);
            panelAccount.Controls.Add(buttonEditAccount);
            panelAccount.Controls.Add(labelLastName);
            panelAccount.Controls.Add(labelEmail);
            panelAccount.Controls.Add(labelFirstName);
            panelAccount.Controls.Add(label5);
            panelAccount.Controls.Add(label4);
            panelAccount.Controls.Add(label3);
            panelAccount.Controls.Add(label2);
            panelAccount.Location = new Point(183, 33);
            panelAccount.Name = "panelAccount";
            panelAccount.Size = new Size(597, 416);
            panelAccount.TabIndex = 4;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.BackColor = Color.SlateGray;
            buttonChangePassword.FlatStyle = FlatStyle.Popup;
            buttonChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangePassword.ForeColor = Color.LightSkyBlue;
            buttonChangePassword.Location = new Point(93, 276);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(209, 31);
            buttonChangePassword.TabIndex = 8;
            buttonChangePassword.Text = "Change Password";
            buttonChangePassword.UseVisualStyleBackColor = false;
            // 
            // buttonEditAccount
            // 
            buttonEditAccount.BackColor = Color.SlateGray;
            buttonEditAccount.FlatStyle = FlatStyle.Popup;
            buttonEditAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditAccount.ForeColor = Color.LightSkyBlue;
            buttonEditAccount.Location = new Point(93, 224);
            buttonEditAccount.Name = "buttonEditAccount";
            buttonEditAccount.Size = new Size(209, 31);
            buttonEditAccount.TabIndex = 7;
            buttonEditAccount.Text = "Edit Profile";
            buttonEditAccount.UseVisualStyleBackColor = false;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastName.ForeColor = Color.LightSkyBlue;
            labelLastName.Location = new Point(214, 136);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(108, 25);
            labelLastName.TabIndex = 6;
            labelLastName.Text = "{lastName}";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.LightSkyBlue;
            labelEmail.Location = new Point(217, 181);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 25);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "{email}";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFirstName.ForeColor = Color.LightSkyBlue;
            labelFirstName.Location = new Point(213, 93);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(113, 25);
            labelFirstName.TabIndex = 4;
            labelFirstName.Text = "{firstName}";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(40, 87);
            label5.Name = "label5";
            label5.Size = new Size(144, 32);
            label5.TabIndex = 3;
            label5.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightSkyBlue;
            label4.Location = new Point(44, 129);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 2;
            label4.Text = "Last Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSkyBlue;
            label3.Location = new Point(101, 175);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 1;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSkyBlue;
            label2.Location = new Point(143, 7);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 0;
            label2.Text = "Account";
            // 
            // panelEditProfile
            // 
            panelEditProfile.BackColor = Color.Transparent;
            panelEditProfile.Controls.Add(buttonCancelEdit);
            panelEditProfile.Controls.Add(textBoxLastNameUpdate);
            panelEditProfile.Controls.Add(textBoxFirstNameUpdate);
            panelEditProfile.Controls.Add(buttonSubmitEdit);
            panelEditProfile.Controls.Add(label9);
            panelEditProfile.Controls.Add(label10);
            panelEditProfile.Controls.Add(label12);
            panelEditProfile.Location = new Point(185, 35);
            panelEditProfile.Name = "panelEditProfile";
            panelEditProfile.Size = new Size(597, 404);
            panelEditProfile.TabIndex = 9;
            // 
            // buttonSubmitEdit
            // 
            buttonSubmitEdit.BackColor = Color.SlateGray;
            buttonSubmitEdit.FlatStyle = FlatStyle.Popup;
            buttonSubmitEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubmitEdit.ForeColor = Color.LightSkyBlue;
            buttonSubmitEdit.Location = new Point(91, 196);
            buttonSubmitEdit.Name = "buttonSubmitEdit";
            buttonSubmitEdit.Size = new Size(209, 31);
            buttonSubmitEdit.TabIndex = 7;
            buttonSubmitEdit.Text = "Submit";
            buttonSubmitEdit.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.LightSkyBlue;
            label9.Location = new Point(40, 87);
            label9.Name = "label9";
            label9.Size = new Size(144, 32);
            label9.TabIndex = 3;
            label9.Text = "First Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.LightSkyBlue;
            label10.Location = new Point(44, 129);
            label10.Name = "label10";
            label10.Size = new Size(147, 32);
            label10.TabIndex = 2;
            label10.Text = "Last Name: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.LightSkyBlue;
            label12.Location = new Point(143, 7);
            label12.Name = "label12";
            label12.Size = new Size(141, 32);
            label12.TabIndex = 0;
            label12.Text = "Edit Profile";
            // 
            // textBoxFirstNameUpdate
            // 
            textBoxFirstNameUpdate.BackColor = Color.SlateGray;
            textBoxFirstNameUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstNameUpdate.ForeColor = Color.LightSkyBlue;
            textBoxFirstNameUpdate.Location = new Point(211, 88);
            textBoxFirstNameUpdate.Name = "textBoxFirstNameUpdate";
            textBoxFirstNameUpdate.PlaceholderText = "First Name";
            textBoxFirstNameUpdate.Size = new Size(152, 29);
            textBoxFirstNameUpdate.TabIndex = 8;
            // 
            // textBoxLastNameUpdate
            // 
            textBoxLastNameUpdate.BackColor = Color.SlateGray;
            textBoxLastNameUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastNameUpdate.ForeColor = Color.LightSkyBlue;
            textBoxLastNameUpdate.Location = new Point(211, 131);
            textBoxLastNameUpdate.Name = "textBoxLastNameUpdate";
            textBoxLastNameUpdate.PlaceholderText = "Last Name";
            textBoxLastNameUpdate.Size = new Size(152, 29);
            textBoxLastNameUpdate.TabIndex = 10;
            // 
            // buttonCancelEdit
            // 
            buttonCancelEdit.BackColor = Color.SlateGray;
            buttonCancelEdit.FlatStyle = FlatStyle.Popup;
            buttonCancelEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelEdit.ForeColor = Color.LightSkyBlue;
            buttonCancelEdit.Location = new Point(91, 237);
            buttonCancelEdit.Name = "buttonCancelEdit";
            buttonCancelEdit.Size = new Size(209, 31);
            buttonCancelEdit.TabIndex = 11;
            buttonCancelEdit.Text = "Cancel";
            buttonCancelEdit.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(panelEditProfile);
            Controls.Add(panelAccount);
            Controls.Add(panelHome);
            Controls.Add(panelNavigation);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Profile";
            ShowIcon = false;
            Text = "CapChat";
            Load += Profile_Load;
            panelNavigation.ResumeLayout(false);
            panelNavigation.PerformLayout();
            panelNavButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)navToggle).EndInit();
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            panelAccount.ResumeLayout(false);
            panelAccount.PerformLayout();
            panelEditProfile.ResumeLayout(false);
            panelEditProfile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogout;
        private Label labelProfileGreeting;
        private Panel panelNavigation;
        private PictureBox navToggle;
        private Button buttonChat;
        private Button buttonHome;
        private Panel panelNavButtons;
        private Label labelProfileName;
        private Panel panelHome;
        private Label label1;
        private Button buttonAccount;
        private Panel panelAccount;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonEditAccount;
        private Label labelLastName;
        private Label labelEmail;
        private Label labelFirstName;
        private Button buttonChangePassword;
        private Panel panelEditProfile;
        private Button buttonSubmitEdit;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox textBoxLastNameUpdate;
        private TextBox textBoxFirstNameUpdate;
        private Button buttonCancelEdit;
    }
}