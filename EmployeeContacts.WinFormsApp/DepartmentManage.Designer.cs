
namespace EmployeeContacts.WinFormsApp
{
    partial class DepartmentManage
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
            this.table_departments = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_employees = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_q_department = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_department_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_department_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_departments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // table_departments
            // 
            this.table_departments.AllowUserToAddRows = false;
            this.table_departments.AllowUserToDeleteRows = false;
            this.table_departments.BackgroundColor = System.Drawing.Color.White;
            this.table_departments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_departments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.department_name});
            this.table_departments.GridColor = System.Drawing.Color.White;
            this.table_departments.Location = new System.Drawing.Point(17, 180);
            this.table_departments.Margin = new System.Windows.Forms.Padding(4);
            this.table_departments.MultiSelect = false;
            this.table_departments.Name = "table_departments";
            this.table_departments.ReadOnly = true;
            this.table_departments.RowTemplate.Height = 25;
            this.table_departments.Size = new System.Drawing.Size(366, 536);
            this.table_departments.TabIndex = 0;
            this.table_departments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_employees_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // department_name
            // 
            this.department_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department_name.HeaderText = "Name";
            this.department_name.Name = "department_name";
            this.department_name.ReadOnly = true;
            // 
            // table_employees
            // 
            this.table_employees.AllowUserToAddRows = false;
            this.table_employees.AllowUserToDeleteRows = false;
            this.table_employees.BackgroundColor = System.Drawing.Color.White;
            this.table_employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.fullname,
            this.email,
            this.pnumber,
            this.status});
            this.table_employees.GridColor = System.Drawing.Color.White;
            this.table_employees.Location = new System.Drawing.Point(391, 13);
            this.table_employees.Margin = new System.Windows.Forms.Padding(4);
            this.table_employees.Name = "table_employees";
            this.table_employees.ReadOnly = true;
            this.table_employees.RowTemplate.Height = 25;
            this.table_employees.Size = new System.Drawing.Size(720, 703);
            this.table_employees.TabIndex = 1;
            this.table_employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_employees_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
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
            // pnumber
            // 
            this.pnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pnumber.HeaderText = "Số điện thoại";
            this.pnumber.Name = "pnumber";
            this.pnumber.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Trạng Thái";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // txt_q_department
            // 
            this.txt_q_department.Location = new System.Drawing.Point(17, 140);
            this.txt_q_department.Margin = new System.Windows.Forms.Padding(4);
            this.txt_q_department.Name = "txt_q_department";
            this.txt_q_department.Size = new System.Drawing.Size(260, 29);
            this.txt_q_department.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(285, 140);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 32);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(17, 100);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(96, 32);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(121, 100);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(96, 32);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Sửa đổi";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(225, 100);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 32);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_department_name
            // 
            this.txt_department_name.Location = new System.Drawing.Point(17, 63);
            this.txt_department_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_department_name.Name = "txt_department_name";
            this.txt_department_name.Size = new System.Drawing.Size(316, 29);
            this.txt_department_name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID phòng ban";
            // 
            // txt_department_id
            // 
            this.txt_department_id.AutoSize = true;
            this.txt_department_id.BackColor = System.Drawing.Color.White;
            this.txt_department_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_department_id.Location = new System.Drawing.Point(121, 7);
            this.txt_department_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_department_id.Name = "txt_department_id";
            this.txt_department_id.Size = new System.Drawing.Size(21, 23);
            this.txt_department_id.TabIndex = 10;
            this.txt_department_id.Text = "0";
            // 
            // DepartmentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 729);
            this.Controls.Add(this.txt_department_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_department_name);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_q_department);
            this.Controls.Add(this.table_employees);
            this.Controls.Add(this.table_departments);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentManage";
            this.Text = "Department";
            ((System.ComponentModel.ISupportInitialize)(this.table_departments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table_departments;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_name;
        private System.Windows.Forms.DataGridView table_employees;
        private System.Windows.Forms.TextBox txt_q_department;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_department_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}