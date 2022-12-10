namespace GLASS_WITH_DATABASE
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regToolStripMenuItem
            // 
            this.regToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem});
            this.regToolStripMenuItem.Name = "regToolStripMenuItem";
            this.regToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.regToolStripMenuItem.Text = "Registration";
            this.regToolStripMenuItem.Click += new System.EventHandler(this.regToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.teacherToolStripMenuItem.Text = "Teacher";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.teacherToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // signoutToolStripMenuItem
            // 
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.signoutToolStripMenuItem.Text = "Sign-out";
            this.signoutToolStripMenuItem.Click += new System.EventHandler(this.signoutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 30);
            this.panel1.TabIndex = 2;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChildForm.BackgroundImage")));
            this.pnlChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(0, 30);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(882, 623);
            this.pnlChildForm.TabIndex = 3;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
    }
}

