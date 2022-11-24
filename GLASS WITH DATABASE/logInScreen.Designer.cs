namespace GLASS_WITH_DATABASE
{
    partial class logInScreen
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
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogInLogInScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(355, 370);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxUsername.Multiline = true;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(194, 27);
            this.tbxUsername.TabIndex = 0;
            this.tbxUsername.Enter += new System.EventHandler(this.tbxUsername_Enter);
            this.tbxUsername.Leave += new System.EventHandler(this.tbxUsername_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 240);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(355, 403);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(194, 27);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // btnLogInLogInScreen
            // 
            this.btnLogInLogInScreen.Location = new System.Drawing.Point(400, 452);
            this.btnLogInLogInScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogInLogInScreen.Name = "btnLogInLogInScreen";
            this.btnLogInLogInScreen.Size = new System.Drawing.Size(105, 24);
            this.btnLogInLogInScreen.TabIndex = 4;
            this.btnLogInLogInScreen.Text = "Log In";
            this.btnLogInLogInScreen.UseVisualStyleBackColor = true;
            this.btnLogInLogInScreen.Click += new System.EventHandler(this.btnLogInLogInScreen_Click);
            // 
            // logInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnLogInLogInScreen);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "logInScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogInLogInScreen;
    }
}