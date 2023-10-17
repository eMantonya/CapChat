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
            buttonLogout = new Button();
            labelProfileGreeting = new Label();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.SlateGray;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.LightSkyBlue;
            buttonLogout.Location = new Point(32, 399);
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
            labelProfileGreeting.Location = new Point(285, 66);
            labelProfileGreeting.Name = "labelProfileGreeting";
            labelProfileGreeting.Size = new Size(88, 32);
            labelProfileGreeting.TabIndex = 1;
            labelProfileGreeting.Text = "Hello, ";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(labelProfileGreeting);
            Controls.Add(buttonLogout);
            DoubleBuffered = true;
            Name = "Profile";
            ShowIcon = false;
            Text = "CapChat";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogout;
        private Label labelProfileGreeting;
    }
}