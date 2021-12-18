
namespace EmployeeContacts.WinFormsApp
{
    partial class Main
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
            this.btn_manage_department = new System.Windows.Forms.Button();
            this.btn_manage_employee = new System.Windows.Forms.Button();
            this.filter_name_employee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filter_department = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_find_employee = new System.Windows.Forms.Button();
            this.table_employees = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_content = new System.Windows.Forms.RichTextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_send_mail = new System.Windows.Forms.Button();
            this.btn_mailbox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_manage_department
            // 
            this.btn_manage_department.Location = new System.Drawing.Point(15, 9);
            this.btn_manage_department.Margin = new System.Windows.Forms.Padding(4);
            this.btn_manage_department.Name = "btn_manage_department";
            this.btn_manage_department.Size = new System.Drawing.Size(158, 32);
            this.btn_manage_department.TabIndex = 0;
            this.btn_manage_department.Text = "Quản lý phòng ban";
            this.btn_manage_department.UseVisualStyleBackColor = true;
            this.btn_manage_department.Click += new System.EventHandler(this.btn_manage_department_Click);
            // 
            // btn_manage_employee
            // 
            this.btn_manage_employee.Location = new System.Drawing.Point(181, 9);
            this.btn_manage_employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_manage_employee.Name = "btn_manage_employee";
            this.btn_manage_employee.Size = new System.Drawing.Size(158, 32);
            this.btn_manage_employee.TabIndex = 1;
            this.btn_manage_employee.Text = "Quản lý nhân viên";
            this.btn_manage_employee.UseVisualStyleBackColor = true;
            this.btn_manage_employee.Click += new System.EventHandler(this.btn_manage_employee_Click);
            // 
            // filter_name_employee
            // 
            this.filter_name_employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filter_name_employee.Location = new System.Drawing.Point(741, 34);
            this.filter_name_employee.Margin = new System.Windows.Forms.Padding(4);
            this.filter_name_employee.Name = "filter_name_employee";
            this.filter_name_employee.Size = new System.Drawing.Size(266, 22);
            this.filter_name_employee.TabIndex = 2;
            this.filter_name_employee.Click += new System.EventHandler(this.filter_name_employee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // filter_department
            // 
            this.filter_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_department.FormattingEnabled = true;
            this.filter_department.Location = new System.Drawing.Point(579, 31);
            this.filter_department.Margin = new System.Windows.Forms.Padding(4);
            this.filter_department.Name = "filter_department";
            this.filter_department.Size = new System.Drawing.Size(154, 29);
            this.filter_department.TabIndex = 4;
            this.filter_department.SelectedIndexChanged += new System.EventHandler(this.filter_department_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lọc phòng ban";
            // 
            // btn_find_employee
            // 
            this.btn_find_employee.Location = new System.Drawing.Point(1015, 28);
            this.btn_find_employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_find_employee.Name = "btn_find_employee";
            this.btn_find_employee.Size = new System.Drawing.Size(96, 32);
            this.btn_find_employee.TabIndex = 6;
            this.btn_find_employee.Text = "Tìm kiếm";
            this.btn_find_employee.UseVisualStyleBackColor = true;
            this.btn_find_employee.Click += new System.EventHandler(this.btn_find_employee_Click);
            // 
            // table_employees
            // 
            this.table_employees.AllowUserToAddRows = false;
            this.table_employees.AllowUserToDeleteRows = false;
            this.table_employees.BackgroundColor = System.Drawing.Color.White;
            this.table_employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.email,
            this.department});
            this.table_employees.GridColor = System.Drawing.Color.White;
            this.table_employees.Location = new System.Drawing.Point(430, 68);
            this.table_employees.Margin = new System.Windows.Forms.Padding(4);
            this.table_employees.Name = "table_employees";
            this.table_employees.ReadOnly = true;
            this.table_employees.RowTemplate.Height = 25;
            this.table_employees.Size = new System.Drawing.Size(681, 648);
            this.table_employees.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.HeaderText = "Họ và Tên";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.HeaderText = "Phòng Ban";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // txt_content
            // 
            this.txt_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_content.Location = new System.Drawing.Point(15, 155);
            this.txt_content.Margin = new System.Windows.Forms.Padding(4);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(407, 521);
            this.txt_content.TabIndex = 8;
            this.txt_content.Text = "";
            // 
            // txt_subject
            // 
            this.txt_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_subject.Location = new System.Drawing.Point(15, 104);
            this.txt_subject.Margin = new System.Windows.Forms.Padding(4);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(407, 22);
            this.txt_subject.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tiêu đề";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nội dung";
            // 
            // btn_send_mail
            // 
            this.btn_send_mail.Location = new System.Drawing.Point(13, 684);
            this.btn_send_mail.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send_mail.Name = "btn_send_mail";
            this.btn_send_mail.Size = new System.Drawing.Size(96, 32);
            this.btn_send_mail.TabIndex = 12;
            this.btn_send_mail.Text = "Gửi Mail";
            this.btn_send_mail.UseVisualStyleBackColor = true;
            this.btn_send_mail.Click += new System.EventHandler(this.btn_send_mail_Click);
            // 
            // btn_mailbox
            // 
            this.btn_mailbox.Location = new System.Drawing.Point(347, 9);
            this.btn_mailbox.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mailbox.Name = "btn_mailbox";
            this.btn_mailbox.Size = new System.Drawing.Size(158, 32);
            this.btn_mailbox.TabIndex = 13;
            this.btn_mailbox.Text = "Email đã nhận";
            this.btn_mailbox.UseVisualStyleBackColor = true;
            this.btn_mailbox.Click += new System.EventHandler(this.btn_mailbox_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1124, 729);
            this.Controls.Add(this.btn_mailbox);
            this.Controls.Add(this.btn_send_mail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.table_employees);
            this.Controls.Add(this.btn_find_employee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filter_department);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filter_name_employee);
            this.Controls.Add(this.btn_manage_employee);
            this.Controls.Add(this.btn_manage_department);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh bạ nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.table_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_manage_department;
        private System.Windows.Forms.Button btn_manage_employee;
        private System.Windows.Forms.TextBox filter_name_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filter_department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_find_employee;
        private System.Windows.Forms.DataGridView table_employees;
        private System.Windows.Forms.RichTextBox txt_content;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_send_mail;
        private System.Windows.Forms.Button btn_mailbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
    }
}