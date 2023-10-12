namespace CapChat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonLoginScreen = new Button();
            buttonRegisterScreen = new Button();
            panelLogin = new Panel();
            buttonLoginConfirm = new Button();
            textBoxLoginPass = new TextBox();
            textBoxLoginEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelRegister = new Panel();
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
            panelRegister.Location = new Point(0, 76);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(786, 385);
            panelRegister.TabIndex = 3;
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
            // 
            // textBoxRegisterConfirmPass
            // 
            textBoxRegisterConfirmPass.BackColor = Color.SlateGray;
            textBoxRegisterConfirmPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRegisterConfirmPass.ForeColor = Color.LightSkyBlue;
            textBoxRegisterConfirmPass.Location = new Point(577, 170);
            textBoxRegisterConfirmPass.Name = "textBoxRegisterConfirmPass";
            textBoxRegisterConfirmPass.PlaceholderText = "First Name";
            textBoxRegisterConfirmPass.Size = new Size(168, 25);
            textBoxRegisterConfirmPass.TabIndex = 10;
            // 
            // textBoxRegisterPass
            // 
            textBoxRegisterPass.BackColor = Color.SlateGray;
            textBoxRegisterPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRegisterPass.ForeColor = Color.LightSkyBlue;
            textBoxRegisterPass.Location = new Point(577, 116);
            textBoxRegisterPass.Name = "textBoxRegisterPass";
            textBoxRegisterPass.PlaceholderText = "First Name";
            textBoxRegisterPass.Size = new Size(168, 25);
            textBoxRegisterPass.TabIndex = 9;
            // 
            // textBoxRegisterLName
            // 
            textBoxRegisterLName.BackColor = Color.SlateGray;
            textBoxRegisterLName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRegisterLName.ForeColor = Color.LightSkyBlue;
            textBoxRegisterLName.Location = new Point(158, 136);
            textBoxRegisterLName.Name = "textBoxRegisterLName";
            textBoxRegisterLName.PlaceholderText = "First Name";
            textBoxRegisterLName.Size = new Size(168, 25);
            textBoxRegisterLName.TabIndex = 8;
            // 
            // textBoxRegisterEmail
            // 
            textBoxRegisterEmail.BackColor = Color.SlateGray;
            textBoxRegisterEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRegisterEmail.ForeColor = Color.LightSkyBlue;
            textBoxRegisterEmail.Location = new Point(158, 191);
            textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            textBoxRegisterEmail.PlaceholderText = "First Name";
            textBoxRegisterEmail.Size = new Size(168, 25);
            textBoxRegisterEmail.TabIndex = 7;
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
            textBoxRegisterFName.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.LightSkyBlue;
            label9.Location = new Point(383, 162);
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
            label8.Location = new Point(465, 111);
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
            // Form1
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
            Name = "Form1";
            ShowIcon = false;
            Text = "CapChat";
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
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
    }
}