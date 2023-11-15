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
            buttonChat = new Button();
            navToggle = new PictureBox();
            panelAccount = new Panel();
            labelEditSuccess = new Label();
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
            buttonCancelEdit = new Button();
            textBoxLastNameUpdate = new TextBox();
            textBoxFirstNameUpdate = new TextBox();
            buttonSubmitEdit = new Button();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            panelChangePassword = new Panel();
            buttonCancelPassChange = new Button();
            labelConfirmPass = new Label();
            labelNewPass = new Label();
            labelCurrentPass = new Label();
            buttonChangePassConfirm = new Button();
            textBoxConfirmPass = new TextBox();
            textBoxNewPass = new TextBox();
            textBoxCurrentPass = new TextBox();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panelChat = new Panel();
            textBoxSend = new TextBox();
            buttonSend = new Button();
            chatBox = new ListBox();
            Placeholder = new Label();
            panelNavigation.SuspendLayout();
            panelNavButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)navToggle).BeginInit();
            panelAccount.SuspendLayout();
            panelEditProfile.SuspendLayout();
            panelChangePassword.SuspendLayout();
            panelChat.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.SlateGray;
            buttonLogout.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogout.Cursor = Cursors.Hand;
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
            panelNavigation.Size = new Size(50, 462);
            panelNavigation.TabIndex = 2;
            // 
            // labelProfileName
            // 
            labelProfileName.AutoSize = true;
            labelProfileName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelProfileName.ForeColor = Color.LightSkyBlue;
            labelProfileName.Location = new Point(51, 9);
            labelProfileName.Name = "labelProfileName";
            labelProfileName.Size = new Size(87, 21);
            labelProfileName.TabIndex = 6;
            labelProfileName.Text = "{first, last}";
            // 
            // panelNavButtons
            // 
            panelNavButtons.Controls.Add(buttonAccount);
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
            // buttonChat
            // 
            buttonChat.BackColor = Color.SlateGray;
            buttonChat.BackgroundImageLayout = ImageLayout.Stretch;
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
            buttonChat.Click += buttonChat_Click;
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
            // panelAccount
            // 
            panelAccount.BackColor = Color.Transparent;
            panelAccount.Controls.Add(labelEditSuccess);
            panelAccount.Controls.Add(buttonChangePassword);
            panelAccount.Controls.Add(buttonEditAccount);
            panelAccount.Controls.Add(labelLastName);
            panelAccount.Controls.Add(labelEmail);
            panelAccount.Controls.Add(labelFirstName);
            panelAccount.Controls.Add(label5);
            panelAccount.Controls.Add(label4);
            panelAccount.Controls.Add(label3);
            panelAccount.Controls.Add(label2);
            panelAccount.Location = new Point(184, 33);
            panelAccount.Name = "panelAccount";
            panelAccount.Size = new Size(597, 408);
            panelAccount.TabIndex = 4;
            // 
            // labelEditSuccess
            // 
            labelEditSuccess.AutoSize = true;
            labelEditSuccess.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEditSuccess.ForeColor = Color.Lime;
            labelEditSuccess.Location = new Point(138, 324);
            labelEditSuccess.Name = "labelEditSuccess";
            labelEditSuccess.Size = new Size(114, 17);
            labelEditSuccess.TabIndex = 10;
            labelEditSuccess.Text = "Account Updated";
            labelEditSuccess.UseWaitCursor = true;
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
            buttonChangePassword.Click += buttonChangePassword_Click;
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
            buttonEditAccount.Click += buttonEditAccount_Click;
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
            panelEditProfile.Location = new Point(185, 32);
            panelEditProfile.Name = "panelEditProfile";
            panelEditProfile.Size = new Size(597, 417);
            panelEditProfile.TabIndex = 9;
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
            buttonCancelEdit.Click += buttonCancelEdit_Click;
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
            buttonSubmitEdit.Click += buttonSubmitEdit_Click;
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
            // panelChangePassword
            // 
            panelChangePassword.BackColor = Color.Transparent;
            panelChangePassword.Controls.Add(buttonCancelPassChange);
            panelChangePassword.Controls.Add(labelConfirmPass);
            panelChangePassword.Controls.Add(labelNewPass);
            panelChangePassword.Controls.Add(labelCurrentPass);
            panelChangePassword.Controls.Add(buttonChangePassConfirm);
            panelChangePassword.Controls.Add(textBoxConfirmPass);
            panelChangePassword.Controls.Add(textBoxNewPass);
            panelChangePassword.Controls.Add(textBoxCurrentPass);
            panelChangePassword.Controls.Add(label11);
            panelChangePassword.Controls.Add(label8);
            panelChangePassword.Controls.Add(label7);
            panelChangePassword.Controls.Add(label6);
            panelChangePassword.Location = new Point(120, 33);
            panelChangePassword.Name = "panelChangePassword";
            panelChangePassword.Size = new Size(659, 393);
            panelChangePassword.TabIndex = 10;
            // 
            // buttonCancelPassChange
            // 
            buttonCancelPassChange.BackColor = Color.SlateGray;
            buttonCancelPassChange.FlatStyle = FlatStyle.Popup;
            buttonCancelPassChange.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelPassChange.ForeColor = Color.LightSkyBlue;
            buttonCancelPassChange.Location = new Point(170, 327);
            buttonCancelPassChange.Name = "buttonCancelPassChange";
            buttonCancelPassChange.Size = new Size(177, 38);
            buttonCancelPassChange.TabIndex = 11;
            buttonCancelPassChange.Text = "Cancel";
            buttonCancelPassChange.UseVisualStyleBackColor = false;
            buttonCancelPassChange.Click += buttonCancelPassChange_Click;
            // 
            // labelConfirmPass
            // 
            labelConfirmPass.AutoSize = true;
            labelConfirmPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelConfirmPass.ForeColor = Color.Red;
            labelConfirmPass.Location = new Point(281, 241);
            labelConfirmPass.Name = "labelConfirmPass";
            labelConfirmPass.Size = new Size(133, 15);
            labelConfirmPass.TabIndex = 10;
            labelConfirmPass.Text = "Passwords must match";
            // 
            // labelNewPass
            // 
            labelNewPass.AutoSize = true;
            labelNewPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNewPass.ForeColor = Color.Red;
            labelNewPass.Location = new Point(281, 192);
            labelNewPass.Name = "labelNewPass";
            labelNewPass.Size = new Size(58, 15);
            labelNewPass.TabIndex = 9;
            labelNewPass.Text = "Required";
            // 
            // labelCurrentPass
            // 
            labelCurrentPass.AutoSize = true;
            labelCurrentPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCurrentPass.ForeColor = Color.Red;
            labelCurrentPass.Location = new Point(281, 141);
            labelCurrentPass.Name = "labelCurrentPass";
            labelCurrentPass.Size = new Size(58, 15);
            labelCurrentPass.TabIndex = 8;
            labelCurrentPass.Text = "Required";
            // 
            // buttonChangePassConfirm
            // 
            buttonChangePassConfirm.BackColor = Color.SlateGray;
            buttonChangePassConfirm.FlatStyle = FlatStyle.Popup;
            buttonChangePassConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangePassConfirm.ForeColor = Color.LightSkyBlue;
            buttonChangePassConfirm.Location = new Point(170, 283);
            buttonChangePassConfirm.Name = "buttonChangePassConfirm";
            buttonChangePassConfirm.Size = new Size(177, 38);
            buttonChangePassConfirm.TabIndex = 7;
            buttonChangePassConfirm.Text = "Submit";
            buttonChangePassConfirm.UseVisualStyleBackColor = false;
            buttonChangePassConfirm.Click += buttonChangePassConfirm_Click;
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.BackColor = Color.SlateGray;
            textBoxConfirmPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConfirmPass.ForeColor = Color.LightSkyBlue;
            textBoxConfirmPass.Location = new Point(281, 209);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.PlaceholderText = "Confirm Password";
            textBoxConfirmPass.Size = new Size(175, 29);
            textBoxConfirmPass.TabIndex = 6;
            textBoxConfirmPass.LostFocus += textBoxConfirmPass_LostFocus;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.BackColor = Color.SlateGray;
            textBoxNewPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNewPass.ForeColor = Color.LightSkyBlue;
            textBoxNewPass.Location = new Point(281, 160);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.PlaceholderText = "New Password";
            textBoxNewPass.Size = new Size(175, 29);
            textBoxNewPass.TabIndex = 5;
            textBoxNewPass.LostFocus += textBoxNewPass_LostFocus;
            // 
            // textBoxCurrentPass
            // 
            textBoxCurrentPass.BackColor = Color.SlateGray;
            textBoxCurrentPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCurrentPass.ForeColor = Color.LightSkyBlue;
            textBoxCurrentPass.Location = new Point(281, 107);
            textBoxCurrentPass.Name = "textBoxCurrentPass";
            textBoxCurrentPass.PlaceholderText = "Current Password";
            textBoxCurrentPass.Size = new Size(175, 29);
            textBoxCurrentPass.TabIndex = 4;
            textBoxCurrentPass.LostFocus += textBoxCurrentPass_LostFocus;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.LightSkyBlue;
            label11.Location = new Point(17, 206);
            label11.Name = "label11";
            label11.Size = new Size(229, 32);
            label11.TabIndex = 3;
            label11.Text = "Confirm Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightSkyBlue;
            label8.Location = new Point(25, 104);
            label8.Name = "label8";
            label8.Size = new Size(223, 32);
            label8.TabIndex = 2;
            label8.Text = "Current Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightSkyBlue;
            label7.Location = new Point(59, 155);
            label7.Name = "label7";
            label7.Size = new Size(187, 32);
            label7.TabIndex = 1;
            label7.Text = "New Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSkyBlue;
            label6.Location = new Point(165, 25);
            label6.Name = "label6";
            label6.Size = new Size(214, 32);
            label6.TabIndex = 0;
            label6.Text = "Change Password";
            // 
            // panelChat
            // 
            panelChat.BackColor = Color.Transparent;
            panelChat.Controls.Add(textBoxSend);
            panelChat.Controls.Add(buttonSend);
            panelChat.Controls.Add(chatBox);
            panelChat.Controls.Add(Placeholder);
            panelChat.Location = new Point(51, 0);
            panelChat.Name = "panelChat";
            panelChat.Size = new Size(731, 462);
            panelChat.TabIndex = 11;
            // 
            // textBoxSend
            // 
            textBoxSend.BackColor = Color.SlateGray;
            textBoxSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSend.ForeColor = Color.LightSkyBlue;
            textBoxSend.Location = new Point(19, 415);
            textBoxSend.Name = "textBoxSend";
            textBoxSend.Size = new Size(542, 29);
            textBoxSend.TabIndex = 3;
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.SlateGray;
            buttonSend.FlatStyle = FlatStyle.Popup;
            buttonSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSend.ForeColor = Color.LightSkyBlue;
            buttonSend.Location = new Point(583, 414);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(108, 30);
            buttonSend.TabIndex = 2;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // chatBox
            // 
            chatBox.BackColor = Color.SlateGray;
            chatBox.BorderStyle = BorderStyle.None;
            chatBox.FormattingEnabled = true;
            chatBox.ItemHeight = 15;
            chatBox.Location = new Point(5, 101);
            chatBox.Name = "chatBox";
            chatBox.Size = new Size(686, 300);
            chatBox.TabIndex = 1;
            // 
            // Placeholder
            // 
            Placeholder.AutoSize = true;
            Placeholder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Placeholder.ForeColor = Color.LightSkyBlue;
            Placeholder.Location = new Point(260, 40);
            Placeholder.Name = "Placeholder";
            Placeholder.Size = new Size(139, 32);
            Placeholder.TabIndex = 0;
            Placeholder.Text = "Chat Room";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(panelChat);
            Controls.Add(panelChangePassword);
            Controls.Add(panelAccount);
            Controls.Add(panelEditProfile);
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
            panelAccount.ResumeLayout(false);
            panelAccount.PerformLayout();
            panelEditProfile.ResumeLayout(false);
            panelEditProfile.PerformLayout();
            panelChangePassword.ResumeLayout(false);
            panelChangePassword.PerformLayout();
            panelChat.ResumeLayout(false);
            panelChat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogout;
        private Label labelProfileGreeting;
        private Panel panelNavigation;
        private PictureBox navToggle;
        private Button buttonChat;
        private Panel panelNavButtons;
        private Label labelProfileName;
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
        private Label labelEditSuccess;
        private Panel panelChangePassword;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button buttonChangePassConfirm;
        private TextBox textBoxConfirmPass;
        private TextBox textBoxNewPass;
        private TextBox textBoxCurrentPass;
        private Label label11;
        private Label labelConfirmPass;
        private Label labelNewPass;
        private Label labelCurrentPass;
        private Button buttonCancelPassChange;
        private Panel panelChat;
        private Label Placeholder;
        private ListBox chatBox;
        private TextBox textBoxSend;
        private Button buttonSend;
    }
}