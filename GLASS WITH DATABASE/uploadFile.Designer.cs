namespace GLASS_WITH_DATABASE
{
    partial class uploadFile
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpload.Location = new System.Drawing.Point(310, 35);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(85, 35);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.Text = "Upload...";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(45, 40);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(255, 22);
            this.txtFilePath.TabIndex = 10;
            // 
            // uploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 268);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uploadFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uploadFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtFilePath;
    }
}