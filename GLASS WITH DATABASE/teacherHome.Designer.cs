namespace GLASS_WITH_DATABASE
{
    partial class teacherHome
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTaskbar = new System.Windows.Forms.Panel();
            this.pnlMainTeacherTab = new System.Windows.Forms.Panel();
            this.subPnlInfo = new System.Windows.Forms.Panel();
            this.btnClass = new System.Windows.Forms.Button();
            this.subPnlBtnClass = new System.Windows.Forms.Panel();
            this.btn1Y = new System.Windows.Forms.Button();
            this.btn2y = new System.Windows.Forms.Button();
            this.btn3y = new System.Windows.Forms.Button();
            this.btn4y = new System.Windows.Forms.Button();
            this.pnlMainChildForm = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.pnlTaskbar.SuspendLayout();
            this.pnlMainTeacherTab.SuspendLayout();
            this.subPnlBtnClass.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlMainChildForm);
            this.pnlMain.Controls.Add(this.pnlMainTeacherTab);
            this.pnlMain.Controls.Add(this.pnlTaskbar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(900, 700);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlTaskbar
            // 
            this.pnlTaskbar.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlTaskbar.Controls.Add(this.menuStrip1);
            this.pnlTaskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskbar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTaskbar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskbar.Name = "pnlTaskbar";
            this.pnlTaskbar.Size = new System.Drawing.Size(900, 30);
            this.pnlTaskbar.TabIndex = 2;
            // 
            // pnlMainTeacherTab
            // 
            this.pnlMainTeacherTab.Controls.Add(this.subPnlBtnClass);
            this.pnlMainTeacherTab.Controls.Add(this.btnClass);
            this.pnlMainTeacherTab.Controls.Add(this.subPnlInfo);
            this.pnlMainTeacherTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainTeacherTab.Location = new System.Drawing.Point(0, 30);
            this.pnlMainTeacherTab.Name = "pnlMainTeacherTab";
            this.pnlMainTeacherTab.Size = new System.Drawing.Size(200, 670);
            this.pnlMainTeacherTab.TabIndex = 3;
            // 
            // subPnlInfo
            // 
            this.subPnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPnlInfo.Location = new System.Drawing.Point(0, 0);
            this.subPnlInfo.Name = "subPnlInfo";
            this.subPnlInfo.Size = new System.Drawing.Size(200, 100);
            this.subPnlInfo.TabIndex = 0;
            // 
            // btnClass
            // 
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClass.Location = new System.Drawing.Point(0, 100);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(200, 60);
            this.btnClass.TabIndex = 1;
            this.btnClass.Text = "Class";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click_1);
            // 
            // subPnlBtnClass
            // 
            this.subPnlBtnClass.Controls.Add(this.btn4y);
            this.subPnlBtnClass.Controls.Add(this.btn3y);
            this.subPnlBtnClass.Controls.Add(this.btn2y);
            this.subPnlBtnClass.Controls.Add(this.btn1Y);
            this.subPnlBtnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPnlBtnClass.Location = new System.Drawing.Point(0, 160);
            this.subPnlBtnClass.Name = "subPnlBtnClass";
            this.subPnlBtnClass.Size = new System.Drawing.Size(200, 180);
            this.subPnlBtnClass.TabIndex = 2;
            // 
            // btn1Y
            // 
            this.btn1Y.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1Y.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn1Y.Location = new System.Drawing.Point(0, 0);
            this.btn1Y.Name = "btn1Y";
            this.btn1Y.Size = new System.Drawing.Size(200, 40);
            this.btn1Y.TabIndex = 0;
            this.btn1Y.Text = "First Year";
            this.btn1Y.UseVisualStyleBackColor = true;
            // 
            // btn2y
            // 
            this.btn2y.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn2y.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn2y.Location = new System.Drawing.Point(0, 40);
            this.btn2y.Name = "btn2y";
            this.btn2y.Size = new System.Drawing.Size(200, 40);
            this.btn2y.TabIndex = 1;
            this.btn2y.Text = "Second Year";
            this.btn2y.UseVisualStyleBackColor = true;
            // 
            // btn3y
            // 
            this.btn3y.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn3y.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3y.Location = new System.Drawing.Point(0, 80);
            this.btn3y.Name = "btn3y";
            this.btn3y.Size = new System.Drawing.Size(200, 40);
            this.btn3y.TabIndex = 2;
            this.btn3y.Text = "Third Year";
            this.btn3y.UseVisualStyleBackColor = true;
            // 
            // btn4y
            // 
            this.btn4y.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn4y.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn4y.Location = new System.Drawing.Point(0, 120);
            this.btn4y.Name = "btn4y";
            this.btn4y.Size = new System.Drawing.Size(200, 40);
            this.btn4y.TabIndex = 3;
            this.btn4y.Text = "Fourth Year";
            this.btn4y.UseVisualStyleBackColor = true;
            // 
            // pnlMainChildForm
            // 
            this.pnlMainChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainChildForm.Location = new System.Drawing.Point(200, 30);
            this.pnlMainChildForm.Name = "pnlMainChildForm";
            this.pnlMainChildForm.Size = new System.Drawing.Size(700, 670);
            this.pnlMainChildForm.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(163, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // teacherHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "teacherHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacherHome";
            this.Load += new System.EventHandler(this.teacherHome_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTaskbar.ResumeLayout(false);
            this.pnlTaskbar.PerformLayout();
            this.pnlMainTeacherTab.ResumeLayout(false);
            this.subPnlBtnClass.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMainTeacherTab;
        private System.Windows.Forms.Panel subPnlBtnClass;
        private System.Windows.Forms.Button btn1Y;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Panel subPnlInfo;
        private System.Windows.Forms.Panel pnlTaskbar;
        private System.Windows.Forms.Button btn4y;
        private System.Windows.Forms.Button btn3y;
        private System.Windows.Forms.Button btn2y;
        private System.Windows.Forms.Panel pnlMainChildForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}