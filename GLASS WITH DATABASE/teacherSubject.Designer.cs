namespace GLASS_WITH_DATABASE
{
    partial class teacherSubject
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
            this.btnMath = new System.Windows.Forms.Button();
            this.btnScience = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMath
            // 
            this.btnMath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMath.Location = new System.Drawing.Point(35, 160);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(205, 95);
            this.btnMath.TabIndex = 0;
            this.btnMath.Text = "Math";
            this.btnMath.UseVisualStyleBackColor = true;
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // btnScience
            // 
            this.btnScience.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnScience.Location = new System.Drawing.Point(340, 160);
            this.btnScience.Name = "btnScience";
            this.btnScience.Size = new System.Drawing.Size(205, 95);
            this.btnScience.TabIndex = 1;
            this.btnScience.Text = "Science";
            this.btnScience.UseVisualStyleBackColor = true;
            this.btnScience.Click += new System.EventHandler(this.btnScience_Click);
            // 
            // btnDS
            // 
            this.btnDS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDS.Location = new System.Drawing.Point(35, 350);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(205, 95);
            this.btnDS.TabIndex = 2;
            this.btnDS.Text = "Discrete Structures";
            this.btnDS.UseVisualStyleBackColor = true;
            this.btnDS.Click += new System.EventHandler(this.btnDS_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInfo.Location = new System.Drawing.Point(345, 350);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(205, 95);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Information Management";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // teacherSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(582, 623);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnDS);
            this.Controls.Add(this.btnScience);
            this.Controls.Add(this.btnMath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacherSubject";
            this.Text = "teacherSubject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.Button btnScience;
        private System.Windows.Forms.Button btnDS;
        private System.Windows.Forms.Button btnInfo;
    }
}