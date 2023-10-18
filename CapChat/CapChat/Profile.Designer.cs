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
            panel1 = new Panel();
            labelProfileName = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(labelProfileName);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelProfileGreeting);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 462);
            panel1.TabIndex = 2;
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
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 262);
            panel2.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateGray;
            button4.FlatAppearance.BorderColor = Color.SlateGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.LightSkyBlue;
            button4.Location = new Point(1, 180);
            button4.Name = "button4";
            button4.Size = new Size(176, 41);
            button4.TabIndex = 4;
            button4.Text = "Help";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.SlateGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightSkyBlue;
            button1.Location = new Point(1, 60);
            button1.Name = "button1";
            button1.Size = new Size(176, 41);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateGray;
            button3.FlatAppearance.BorderColor = Color.SlateGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.LightSkyBlue;
            button3.Location = new Point(1, 140);
            button3.Name = "button3";
            button3.Size = new Size(176, 41);
            button3.TabIndex = 3;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.FlatAppearance.BorderColor = Color.SlateGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightSkyBlue;
            button2.Location = new Point(1, 100);
            button2.Name = "button2";
            button2.Size = new Size(176, 41);
            button2.TabIndex = 2;
            button2.Text = "Chat";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ClientGUI.Properties.Resources.hamburger;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 36);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Controls.Add(buttonLogout);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Profile";
            ShowIcon = false;
            Text = "CapChat";
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogout;
        private Label labelProfileGreeting;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label labelProfileName;
    }
}