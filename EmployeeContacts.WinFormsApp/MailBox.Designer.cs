
namespace EmployeeContacts.WinFormsApp
{
    partial class MailBox
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
            this.table_mails = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_mails)).BeginInit();
            this.SuspendLayout();
            // 
            // table_mails
            // 
            this.table_mails.AllowUserToAddRows = false;
            this.table_mails.AllowUserToDeleteRows = false;
            this.table_mails.BackgroundColor = System.Drawing.Color.White;
            this.table_mails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_mails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_mails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.table_mails.GridColor = System.Drawing.Color.White;
            this.table_mails.Location = new System.Drawing.Point(13, 63);
            this.table_mails.Margin = new System.Windows.Forms.Padding(4);
            this.table_mails.MultiSelect = false;
            this.table_mails.Name = "table_mails";
            this.table_mails.ReadOnly = true;
            this.table_mails.RowTemplate.Height = 25;
            this.table_mails.Size = new System.Drawing.Size(1098, 653);
            this.table_mails.TabIndex = 0;
            this.table_mails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_mails_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "STT";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Người gửi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tiêu đề";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thời gian";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(966, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(146, 44);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "Làm mới";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // MailBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 729);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.table_mails);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailBox";
            this.Text = "Hộp Thư";
            ((System.ComponentModel.ISupportInitialize)(this.table_mails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table_mails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button refresh;
    }
}