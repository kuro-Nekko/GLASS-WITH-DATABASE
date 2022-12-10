namespace GLASS_WITH_DATABASE
{
    partial class calendarEvent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.remindersDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddReminder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.remindersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(30, 45);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(163, 20);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "MONTH DAY, YEAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reminders";
            // 
            // remindersDataGridView
            // 
            this.remindersDataGridView.AllowUserToOrderColumns = true;
            this.remindersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.remindersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.remindersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.remindersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.remindersDataGridView.Location = new System.Drawing.Point(30, 110);
            this.remindersDataGridView.Name = "remindersDataGridView";
            this.remindersDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.remindersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.remindersDataGridView.RowTemplate.Height = 24;
            this.remindersDataGridView.Size = new System.Drawing.Size(520, 185);
            this.remindersDataGridView.TabIndex = 5;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddReminder.Location = new System.Drawing.Point(220, 335);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(145, 45);
            this.btnAddReminder.TabIndex = 7;
            this.btnAddReminder.Text = "Add";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // calendarEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(580, 393);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.remindersDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calendarEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar Event";
            this.Load += new System.EventHandler(this.calendarEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remindersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView remindersDataGridView;
        private System.Windows.Forms.Button btnAddReminder;
    }
}