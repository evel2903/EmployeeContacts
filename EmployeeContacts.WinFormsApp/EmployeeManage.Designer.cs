
namespace EmployeeContacts.WinFormsApp
{
    partial class EmployeeManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_pnumber = new System.Windows.Forms.TextBox();
            this.txt_q_employee = new System.Windows.Forms.TextBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.txt_filter_department = new System.Windows.Forms.ComboBox();
            this.txt_change = new System.Windows.Forms.Label();
            this.dt_dob = new System.Windows.Forms.DateTimePicker();
            this.table_employees = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_edt = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_endwork = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(831, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Trạng thái";
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_id.Location = new System.Drawing.Point(16, 37);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(21, 23);
            this.txt_id.TabIndex = 9;
            this.txt_id.Text = "0";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(72, 34);
            this.txt_fullname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(253, 29);
            this.txt_fullname.TabIndex = 10;
            // 
            // txt_pnumber
            // 
            this.txt_pnumber.Location = new System.Drawing.Point(831, 34);
            this.txt_pnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pnumber.Name = "txt_pnumber";
            this.txt_pnumber.Size = new System.Drawing.Size(280, 29);
            this.txt_pnumber.TabIndex = 11;
            // 
            // txt_q_employee
            // 
            this.txt_q_employee.Location = new System.Drawing.Point(699, 141);
            this.txt_q_employee.Margin = new System.Windows.Forms.Padding(4);
            this.txt_q_employee.Name = "txt_q_employee";
            this.txt_q_employee.Size = new System.Drawing.Size(308, 29);
            this.txt_q_employee.TabIndex = 12;
            this.txt_q_employee.Click += new System.EventHandler(this.txt_q_employee_Click);
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(203, 92);
            this.cb_department.Margin = new System.Windows.Forms.Padding(4);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(154, 29);
            this.cb_department.TabIndex = 13;
            // 
            // txt_filter_department
            // 
            this.txt_filter_department.FormattingEnabled = true;
            this.txt_filter_department.Location = new System.Drawing.Point(134, 134);
            this.txt_filter_department.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filter_department.Name = "txt_filter_department";
            this.txt_filter_department.Size = new System.Drawing.Size(154, 29);
            this.txt_filter_department.TabIndex = 14;
            this.txt_filter_department.SelectedIndexChanged += new System.EventHandler(this.txt_filter_department_SelectedIndexChanged);
            // 
            // txt_change
            // 
            this.txt_change.AutoSize = true;
            this.txt_change.BackColor = System.Drawing.Color.White;
            this.txt_change.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_change.Location = new System.Drawing.Point(365, 95);
            this.txt_change.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(57, 23);
            this.txt_change.TabIndex = 16;
            this.txt_change.Text = "Không";
            // 
            // dt_dob
            // 
            this.dt_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dob.Location = new System.Drawing.Point(333, 34);
            this.dt_dob.Margin = new System.Windows.Forms.Padding(4);
            this.dt_dob.Name = "dt_dob";
            this.dt_dob.Size = new System.Drawing.Size(137, 29);
            this.dt_dob.TabIndex = 17;
            // 
            // table_employees
            // 
            this.table_employees.AllowUserToAddRows = false;
            this.table_employees.AllowUserToDeleteRows = false;
            this.table_employees.BackgroundColor = System.Drawing.Color.White;
            this.table_employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.table_employees.GridColor = System.Drawing.Color.White;
            this.table_employees.Location = new System.Drawing.Point(13, 176);
            this.table_employees.Margin = new System.Windows.Forms.Padding(4);
            this.table_employees.MultiSelect = false;
            this.table_employees.Name = "table_employees";
            this.table_employees.ReadOnly = true;
            this.table_employees.RowTemplate.Height = 25;
            this.table_employees.Size = new System.Drawing.Size(1098, 540);
            this.table_employees.TabIndex = 19;
            this.table_employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_employees_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Họ Và Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Trạng thái";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Chuyển phòng ban";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Phòng ban";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(570, 34);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(253, 29);
            this.txt_email.TabIndex = 20;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gender.Location = new System.Drawing.Point(478, 34);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(84, 29);
            this.cb_gender.TabIndex = 21;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(703, 89);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(96, 32);
            this.btn_create.TabIndex = 22;
            this.btn_create.Text = "Thêm mới";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Lọc phòng ban";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1015, 139);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 32);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edt
            // 
            this.btn_edt.Enabled = false;
            this.btn_edt.Location = new System.Drawing.Point(807, 89);
            this.btn_edt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edt.Name = "btn_edt";
            this.btn_edt.Size = new System.Drawing.Size(96, 32);
            this.btn_edt.TabIndex = 25;
            this.btn_edt.Text = "Thay đổi";
            this.btn_edt.UseVisualStyleBackColor = true;
            this.btn_edt.Click += new System.EventHandler(this.btn_edt_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(911, 89);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 32);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_endwork
            // 
            this.btn_endwork.Enabled = false;
            this.btn_endwork.Location = new System.Drawing.Point(1015, 89);
            this.btn_endwork.Margin = new System.Windows.Forms.Padding(4);
            this.btn_endwork.Name = "btn_endwork";
            this.btn_endwork.Size = new System.Drawing.Size(96, 32);
            this.btn_endwork.TabIndex = 29;
            this.btn_endwork.Text = "Nghỉ việc";
            this.btn_endwork.UseVisualStyleBackColor = true;
            this.btn_endwork.Click += new System.EventHandler(this.btn_endwork_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Chuyển phòng ban";
            // 
            // txt_status
            // 
            this.txt_status.Enabled = false;
            this.txt_status.Location = new System.Drawing.Point(16, 92);
            this.txt_status.Margin = new System.Windows.Forms.Padding(4);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(179, 29);
            this.txt_status.TabIndex = 31;
            // 
            // EmployeeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 729);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_endwork);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edt);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.table_employees);
            this.Controls.Add(this.dt_dob);
            this.Controls.Add(this.txt_change);
            this.Controls.Add(this.txt_filter_department);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.txt_q_employee);
            this.Controls.Add(this.txt_pnumber);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeManage";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.table_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_pnumber;
        private System.Windows.Forms.TextBox txt_q_employee;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.ComboBox txt_filter_department;
        private System.Windows.Forms.Label txt_change;
        private System.Windows.Forms.DateTimePicker dt_dob;
        private System.Windows.Forms.DataGridView table_employees;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_edt;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_endwork;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_status;
    }
}