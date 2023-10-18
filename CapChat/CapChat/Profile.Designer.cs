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
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            navToggle = new PictureBox();
            panelNavigation.SuspendLayout();
            panelNavButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)navToggle).BeginInit();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.SlateGray;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.LightSkyBlue;
            buttonLogout.Location = new Point(548, 318);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(153, 34);
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
            labelProfileGreeting.Location = new Point(48, 79);
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
            labelProfileName.Location = new Point(43, 161);
            labelProfileName.Name = "labelProfileName";
            labelProfileName.Size = new Size(87, 21);
            labelProfileName.TabIndex = 6;
            labelProfileName.Text = "{first, last}";
            // 
            // panelNavButtons
            // 
            panelNavButtons.Controls.Add(button4);
            panelNavButtons.Controls.Add(button1);
            panelNavButtons.Controls.Add(button3);
            panelNavButtons.Controls.Add(button2);
            panelNavButtons.Location = new Point(0, 200);
            panelNavButtons.Name = "panelNavButtons";
            panelNavButtons.Size = new Size(177, 262);
            panelNavButtons.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateGray;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.SlateGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.LightSkyBlue;
            button4.Location = new Point(1, 180);
            button4.Name = "button4";
            button4.Size = new Size(173, 41);
            button4.TabIndex = 4;
            button4.Text = "Help";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.SlateGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightSkyBlue;
            button1.Location = new Point(1, 60);
            button1.Name = "button1";
            button1.Size = new Size(173, 41);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateGray;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.SlateGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.LightSkyBlue;
            button3.Location = new Point(1, 140);
            button3.Name = "button3";
            button3.Size = new Size(173, 41);
            button3.TabIndex = 3;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.SlateGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightSkyBlue;
            button2.Location = new Point(1, 100);
            button2.Name = "button2";
            button2.Size = new Size(173, 41);
            button2.TabIndex = 2;
            button2.Text = "Chat";
            button2.UseVisualStyleBackColor = false;
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
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(panelNavigation);
            Controls.Add(buttonLogout);
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
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogout;
        private Label labelProfileGreeting;
        private Panel panelNavigation;
        private PictureBox navToggle;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panelNavButtons;
        private Label labelProfileName;
    }
}