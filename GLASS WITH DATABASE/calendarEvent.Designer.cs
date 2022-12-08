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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.remindersDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.remindersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(35, 35);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(131, 16);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "MONTH DAY, YEAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reminders";
            // 
            // remindersDataGridView
            // 
            this.remindersDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.remindersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.remindersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.remindersDataGridView.Location = new System.Drawing.Point(30, 110);
            this.remindersDataGridView.Name = "remindersDataGridView";
            this.remindersDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.remindersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.remindersDataGridView.RowTemplate.Height = 24;
            this.remindersDataGridView.Size = new System.Drawing.Size(520, 305);
            this.remindersDataGridView.TabIndex = 5;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddReminder.Location = new System.Drawing.Point(105, 435);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(90, 25);
            this.btnAddReminder.TabIndex = 7;
            this.btnAddReminder.Text = "Add";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // calendarEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 522);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
    }
}