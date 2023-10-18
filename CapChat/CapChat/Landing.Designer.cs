namespace CapChat
{
    partial class Landing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            buttonLoginScreen = new Button();
            buttonRegisterScreen = new Button();
            panelLogin = new Panel();
            labelLoginPass = new Label();
            labelLoginEmail = new Label();
            labelRegisterSuccess2 = new Label();
            labelRegisterSuccess = new Label();
            buttonLoginConfirm = new Button();
            textBoxLoginPass = new TextBox();
            textBoxLoginEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelRegister = new Panel();
            errorConfirmPass = new Label();
            errorPass = new Label();
            errorEmail = new Label();
            errorLastName = new Label();
            errorFirstName = new Label();
            checkmarkConfirmPass = new PictureBox();
            checkmarkPass = new PictureBox();
            buttonRegisterSubmit = new Button();
            textBoxRegisterConfirmPass = new TextBox();
            textBoxRegisterPass = new TextBox();
            textBoxRegisterLName = new TextBox();
            textBoxRegisterEmail = new TextBox();
            textBoxRegisterFName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelLogin.SuspendLayout();
            panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkmarkConfirmPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkmarkPass).BeginInit();
            SuspendLayout();
            // 
            // buttonLoginScreen
            // 
            buttonLoginScreen.BackColor = Color.SlateGray;
            buttonLoginScreen.FlatStyle = FlatStyle.Popup;
            buttonLoginScreen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLoginScreen.ForeColor = Color.LightSkyBlue;
            buttonLoginScreen.Location = new Point(83, 35);
            buttonLoginScreen.Name = "buttonLoginScreen";
            buttonLoginScreen.Size = new Size(207, 35);
            buttonLoginScreen.TabIndex = 0;
            buttonLoginScreen.Text = "Login";
            buttonLoginScreen.UseVisualStyleBackColor = false;
            buttonLoginScreen.Click += buttonLoginScreen_Click;
            // 
            // buttonRegisterScreen
            // 
            buttonRegisterScreen.BackColor = Color.SlateGray;
            buttonRegisterScreen.FlatStyle = FlatStyle.Popup;
            buttonRegisterScreen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegisterScreen.ForeColor = Color.LightSkyBlue;
            buttonRegisterScreen.Location = new Point(474, 35);
            buttonRegisterScreen.Name = "buttonRegisterScreen";
            buttonRegisterScreen.Size = new Size(215, 35);
            buttonRegisterScreen.TabIndex = 1;
            buttonRegisterScreen.Text = "Register";
            buttonRegisterScreen.UseVisualStyleBackColor = false;
            buttonRegisterScreen.Click += buttonRegisterScreen_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Transparent;
            panelLogin.Controls.Add(labelLoginPass);
            panelLogin.Controls.Add(labelLoginEmail);
            panelLogin.Controls.Add(labelRegisterSuccess2);
            panelLogin.Controls.Add(labelRegisterSuccess);
            panelLogin.Controls.Add(buttonLoginConfirm);
            panelLogin.Controls.Add(textBoxLoginPass);
            panelLogin.Controls.Add(textBoxLoginEmail);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            panelLogin.ForeColor = Color.Black;
            panelLogin.Location = new Point(0, 76);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(786, 385);
            panelLogin.TabIndex = 2;
            // 
            // labelLoginPass
            // 
            labelLoginPass.AutoSize = true;
            labelLoginPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoginPass.ForeColor = Color.Red;
            labelLoginPass.Location = new Point(332, 211);
            labelLoginPass.Name = "labelLoginPass";
            labelLoginPass.Size = new Size(72, 20);
            labelLoginPass.TabIndex = 9;
            labelLoginPass.Text = "Required";
            labelLoginPass.UseMnemonic = false;
            // 
            // labelLoginEmail
            // 
            labelLoginEmail.AutoSize = true;
            labelLoginEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoginEmail.ForeColor = Color.Red;
            labelLoginEmail.Location = new Point(332, 150);
            labelLoginEmail.Name = "labelLoginEmail";
            labelLoginEmail.Size = new Size(72, 20);
            labelLoginEmail.TabIndex = 8;
            labelLoginEmail.Text = "Required";
            labelLoginEmail.UseMnemonic = false;
            // 
            // labelRegisterSuccess2
            // 
            labelRegisterSuccess2.AutoSize = true;
            labelRegisterSuccess2.ForeColor = Color.Lime;
            labelRegisterSuccess2.Location = new Point(321, 79);
            labelRegisterSuccess2.Name = "labelRegisterSuccess2";
            labelRegisterSuccess2.Size = new Size(0, 25);
            labelRegisterSuccess2.TabIndex = 7;
            // 
            // labelRegisterSuccess
            // 
            labelRegisterSuccess.AutoSize = true;
            labelRegisterSuccess.ForeColor = Color.Lime;
            labelRegisterSuccess.Location = new Point(302, 56);
            labelRegisterSuccess.Name = "labelRegisterSuccess";
            labelRegisterSuccess.Size = new Size(0, 25);
            labelRegisterSuccess.TabIndex = 6;
            // 
            // buttonLoginConfirm
            // 
            buttonLoginConfirm.BackColor = Color.LightSkyBlue;
            buttonLoginConfirm.FlatStyle = FlatStyle.Popup;
            buttonLoginConfirm.ForeColor = SystemColors.ActiveCaptionText;
            buttonLoginConfirm.Location = new Point(243, 291);
            buttonLoginConfirm.Name = "buttonLoginConfirm";
            buttonLoginConfirm.Size = new Size(268, 38);
            buttonLoginConfirm.TabIndex = 5;
            buttonLoginConfirm.Text = "Login";
            buttonLoginConfirm.UseVisualStyleBackColor = false;
            buttonLoginConfirm.Click += buttonLoginConfirm_Click;
            // 
            // textBoxLoginPass
            // 
            textBoxLoginPass.BackColor = Color.SlateGray;
            textBoxLoginPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLoginPass.ForeColor = Color.LightSkyBlue;
            textBoxLoginPass.Location = new Point(332, 183);
            textBoxLoginPass.Name = "textBoxLoginPass";
            textBoxLoginPass.PasswordChar = '*';
            textBoxLoginPass.PlaceholderText = "Password";
            textBoxLoginPass.Size = new Size(210, 25);
            textBoxLoginPass.TabIndex = 4;
            textBoxLoginPass.LostFocus += textBoxLoginPass_LostFocus;
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.BackColor = Color.SlateGray;
            textBoxLoginEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLoginEmail.ForeColor = Color.LightSkyBlue;
            textBoxLoginEmail.Location = new Point(332, 122);
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.PlaceholderText = "Email";
            textBoxLoginEmail.Size = new Size(210, 25);
            textBoxLoginEmail.TabIndex = 3;
            textBoxLoginEmail.LostFocus += textBoxLoginEmail_LostFocus;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSkyBlue;
            label3.Location = new Point(243, 115);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSkyBlue;
            label2.Location = new Point(197, 176);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Location = new Point(342, 22);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.Transparent;
            panelRegister.Controls.Add(errorConfirmPass);
            panelRegister.Controls.Add(errorPass);
            panelRegister.Controls.Add(errorEmail);
            panelRegister.Controls.Add(errorLastName);
            panelRegister.Controls.Add(errorFirstName);
            panelRegister.Controls.Add(checkmarkConfirmPass);
            panelRegister.Controls.Add(checkmarkPass);
            panelRegister.Controls.Add(buttonRegisterSubmit);
            panelRegister.Controls.Add(textBoxRegisterConfirmPass);
            panelRegister.Controls.Add(textBoxRegisterPass);
            panelRegister.Controls.Add(textBoxRegisterLName);
            panelRegister.Controls.Add(textBoxRegisterEmail);
            panelRegister.Controls.Add(textBoxRegisterFName);
            panelRegister.Controls.Add(label9);
            panelRegister.Controls.Add(label8);
            panelRegister.Controls.Add(label7);
            panelRegister.Controls.Add(label6);
            panelRegister.Controls.Add(label5);
            panelRegister.Controls.Add(label4);
            panelRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            panelRegister.Location = new Point(-1, 76);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(786, 385);
            panelRegister.TabIndex = 3;
            // 
            // errorConfirmPass
            // 
            errorConfirmPass.AutoSize = true;
            errorConfirmPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorConfirmPass.ForeColor = Color.Red;
            errorConfirmPass.Location = new Point(443, 191);
            errorConfirmPass.Name = "errorConfirmPass";
            errorConfirmPass.Size = new Size(149, 17);
            errorConfirmPass.TabIndex = 18;
            errorConfirmPass.Text = "Passwords must match";
            // 
            // errorPass
            // 
            errorPass.AutoSize = true;
            errorPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorPass.ForeColor = Color.Red;
            errorPass.Location = new Point(443, 144);
            errorPass.Name = "errorPass";
            errorPass.Size = new Size(185, 17);
            errorPass.TabIndex = 17;
            errorPass.Text = "Must be at least 10 charaters";
            // 
            // errorEmail
            // 
            errorEmail.AutoSize = true;
            errorEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorEmail.ForeColor = Color.Red;
            errorEmail.Location = new Point(158, 219);
            errorEmail.Name = "errorEmail";
            errorEmail.Size = new Size(63, 17);
            errorEmail.TabIndex = 16;
            errorEmail.Text = "Required";
            // 
            // errorLastName
            // 
            errorLastName.AutoSize = true;
            errorLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorLastName.ForeColor = Color.Red;
            errorLastName.Location = new Point(158, 164);
            errorLastName.Name = "errorLastName";
            errorLastName.Size = new Size(63, 17);
            errorLastName.TabIndex = 15;
            errorLastName.Text = "Required";
            // 
            // errorFirstName
            // 
            errorFirstName.AutoSize = true;
            errorFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorFirstName.ForeColor = Color.Red;
            errorFirstName.Location = new Point(158, 111);
            errorFirstName.Name = "errorFirstName";
            errorFirstName.Size = new Size(63, 17);
            errorFirstName.TabIndex = 14;
            errorFirstName.Text = "Required";
            // 
            // checkmarkConfirmPass
            // 
            checkmarkConfirmPass.BackColor = Color.Transparent;
            checkmarkConfirmPass.BackgroundImage = (Image)resources.GetObject("checkmarkConfirmPass.BackgroundImage");
            checkmarkConfirmPass.BackgroundImageLayout = ImageLayout.Stretch;
            checkmarkConfirmPass.Location = new Point(733, 157);
            checkmarkConfirmPass.Name = "checkmarkConfirmPass";
            checkmarkConfirmPass.Size = new Size(48, 38);
            checkmarkConfirmPass.TabIndex = 13;
            checkmarkConfirmPass.TabStop = false;
            // 
            // checkmarkPass
            // 
            checkmarkPass.BackColor = Color.Transparent;
            checkmarkPass.BackgroundImage = (Image)resources.GetObject("checkmarkPass.BackgroundImage");
            checkmarkPass.BackgroundImageLayout = ImageLayout.Stretch;
            checkmarkPass.Location = new Point(733, 110);
            checkmarkPass.Name = "checkmarkPass";
            checkmarkPass.Size = new Size(48, 38);
            checkmarkPass.TabIndex = 12;
            checkmarkPass.TabStop = false;
            // 
            // buttonRegisterSubmit
            // 
            buttonRegisterSubmit.BackColor = Color.LightSkyBlue;
            buttonRegisterSubmit.FlatStyle = FlatStyle.Popup;
            buttonRegisterSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegisterSubmit.ForeColor = SystemColors.ActiveCaptionText;
            buttonRegisterSubmit.Location = new Point(243, 291);
            buttonRegisterSubmit.Name = "buttonRegisterSubmit";
            buttonRegisterSubmit.Size = new Size(268, 38);
            buttonRegisterSubmit.TabIndex = 11;
            buttonRegisterSubmit.Text = "Register";
            buttonRegisterSubmit.UseVisualStyleBackColor = false;
            buttonRegisterSubmit.Click += buttonRegisterSubmit_Click;
            // 
            // textBoxRegisterConfirmPass
            // 
            textBoxRegisterConfirmPass.BackColor = Color.SlateGray;
            textBoxRegisterConfirmPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRegisterConfirmPass.ForeColor = Color.LightSkyBlue;
            textBoxRegisterConfirmPass.Location = new Point(564, 164);
            textBoxRegisterConfirmPass.Name = "textBoxRegisterConfirmPass";
            textBoxRegisterConfirmPass.PlaceholderText = "Confirm Password";
            textBoxRegisterConfirmPass.Size = new Size(168, 25);
            textBoxRegisterConfirmPass.TabIndex = 5;
            textBoxRegisterConfirmPass.TextChanged += textBoxRegisterConfirmPass_TextChanged;
            textBoxRegisterConfirmPass.LostFocus += textBoxRegisterConfirmPass_LostFocus;
            // 
            // textBoxRegisterPass
            // 
            textBoxRegisterPass.BackColor = Color.SlateGray;
            textBoxRegisterPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRegisterPass.ForeColor = Color.LightSkyBlue;
            textBoxRegisterPass.Location = new Point(564, 117);
            textBoxRegisterPass.Name = "textBoxRegisterPass";
            textBoxRegisterPass.PlaceholderText = "Password";
            textBoxRegisterPass.Size = new Size(168, 25);
            textBoxRegisterPass.TabIndex = 4;
            textBoxRegisterPass.TextChanged += textBoxRegisterPass_TextChanged;
            textBoxRegisterPass.LostFocus += textBoxRegisterPass_LostFocus;
            // 
            // textBoxRegisterLName
            // 
            textBoxRegisterLName.BackColor = Color.SlateGray;
            textBoxRegisterLName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRegisterLName.ForeColor = Color.LightSkyBlue;
            textBoxRegisterLName.Location = new Point(158, 136);
            textBoxRegisterLName.Name = "textBoxRegisterLName";
            textBoxRegisterLName.PlaceholderText = "Last Name";
            textBoxRegisterLName.Size = new Size(168, 25);
            textBoxRegisterLName.TabIndex = 2;
            textBoxRegisterLName.LostFocus += textBoxRegisterLName_LostFocus;
            // 
            // textBoxRegisterEmail
            // 
            textBoxRegisterEmail.BackColor = Color.SlateGray;
            textBoxRegisterEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRegisterEmail.ForeColor = Color.LightSkyBlue;
            textBoxRegisterEmail.Location = new Point(158, 191);
            textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            textBoxRegisterEmail.PlaceholderText = "Email";
            textBoxRegisterEmail.Size = new Size(168, 25);
            textBoxRegisterEmail.TabIndex = 3;
            textBoxRegisterEmail.LostFocus += textBoxRegisterEmail_LostFocus;
            // 
            // textBoxRegisterFName
            // 
            textBoxRegisterFName.BackColor = Color.SlateGray;
            textBoxRegisterFName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRegisterFName.ForeColor = Color.LightSkyBlue;
            textBoxRegisterFName.Location = new Point(158, 84);
            textBoxRegisterFName.Name = "textBoxRegisterFName";
            textBoxRegisterFName.PlaceholderText = "First Name";
            textBoxRegisterFName.Size = new Size(168, 25);
            textBoxRegisterFName.TabIndex = 1;
            textBoxRegisterFName.LostFocus += textBoxRegisterFName_LostFocus;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.LightSkyBlue;
            label9.Location = new Point(370, 164);
            label9.Name = "label9";
            label9.Size = new Size(188, 28);
            label9.TabIndex = 5;
            label9.Text = "Confirm Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightSkyBlue;
            label8.Location = new Point(452, 111);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 4;
            label8.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightSkyBlue;
            label7.Location = new Point(35, 133);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 3;
            label7.Text = "Last Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSkyBlue;
            label6.Location = new Point(83, 183);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 2;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(32, 79);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 1;
            label5.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightSkyBlue;
            label4.Location = new Point(332, 8);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 0;
            label4.Text = "Register";
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(panelRegister);
            Controls.Add(panelLogin);
            Controls.Add(buttonRegisterScreen);
            Controls.Add(buttonLoginScreen);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Landing";
            ShowIcon = false;
            Text = "CapChat";
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)checkmarkConfirmPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkmarkPass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLoginScreen;
        private Button buttonRegisterScreen;
        private Panel panelLogin;
        private TextBox textBoxLoginEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonLoginConfirm;
        private TextBox textBoxLoginPass;
        private Panel panelRegister;
        private Label label4;
        private TextBox textBoxRegisterFName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBoxRegisterConfirmPass;
        private TextBox textBoxRegisterPass;
        private TextBox textBoxRegisterLName;
        private TextBox textBoxRegisterEmail;
        private Button buttonRegisterSubmit;
        private PictureBox checkmarkPass;
        private Label errorConfirmPass;
        private Label errorPass;
        private Label errorEmail;
        private Label errorLastName;
        private Label errorFirstName;
        private PictureBox checkmarkConfirmPass;
        private Label labelRegisterSuccess2;
        private Label labelRegisterSuccess;
        private Label labelLoginEmail;
        private Label labelLoginPass;
    }
}