using EmployeeContacts.Data.Models;
using EmployeeContacts.Services.Departments;
using EmployeeContacts.Services.Email;
using EmployeeContacts.Services.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeContacts.WinFormsApp
{
    public partial class Main : Form
    {
        private EmployeeServices employeeServices;
        private DepartmentServices departmentServices;
        private EmailServices emailServices;
        public Main()
        {
            InitializeComponent();
            employeeServices = new EmployeeServices();
            departmentServices = new DepartmentServices();
            emailServices = new EmailServices();

            loadDataTable(0);
            loadDepartmentFilter();
        }

        private void loadDataTable(int department_id)
        {
            table_employees.Rows.Clear();
            List<Employee> employees;
            //get all employee
            if (department_id == 0)
            {
                employees = employeeServices.GetAll();
            }
            else
            {
                employees = departmentServices.GetEmployees(department_id);
            }

            employees.ForEach(_e =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(table_employees);
                row.Cells[0].Value = _e.EmployeeId;
                row.Cells[1].Value = _e.EmployeeFullname;
                row.Cells[2].Value = _e.EmployeeEmail;
                row.Cells[3].Value = departmentServices.GetById(_e.DepartmentId).DepartmentName;

                table_employees.Rows.Add(row);
            });
        }
        private void loadDataTable(List<Employee> employees)
        {
            table_employees.Rows.Clear();

            employees.ForEach(_e =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(table_employees);
                row.Cells[0].Value = _e.EmployeeId;
                row.Cells[1].Value = _e.EmployeeFullname;
                row.Cells[2].Value = _e.EmployeeEmail;
                row.Cells[3].Value = departmentServices.GetById(_e.DepartmentId).DepartmentName;

                table_employees.Rows.Add(row);
            });
        }
        private void loadDepartmentFilter()
        {
            filter_department.Items.Add("0 - Get All");

            List<Department> departments = departmentServices.GetAll();
            departments.ForEach(_d =>
            {
                filter_department.Items.Add(_d.DepartmentId + " - " + _d.DepartmentName);
            });
            filter_department.SelectedIndex = 0;
        }

        private void filter_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get department id
            string selectedValue = filter_department.SelectedItem.ToString();
            int department_id = Int32.Parse(selectedValue.Substring(0, selectedValue.IndexOf(" ")));

            loadDataTable(department_id);
        }

        private void filter_name_employee_Click(object sender, EventArgs e)
        {
            filter_department.SelectedIndex = 0;
        }

        private void btn_find_employee_Click(object sender, EventArgs e)
        {
            string q = filter_name_employee.Text;
            var list = employeeServices.FilterByName(q);
            loadDataTable(list);
        }

        private async void btn_send_mail_Click(object sender, EventArgs e)
        {

            if (txt_subject.Text.Equals("") || txt_content.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tiêu đề/nội dung cho Email.","Lỗi nhập liệu");
                return;
            }

            var selectedRows = table_employees.SelectedRows
                .OfType<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .ToArray();

            if(selectedRows.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn người nhận Email.", "Lỗi nhập liệu");
                return;
            }

            foreach (var row in selectedRows)
            {
                await emailServices.SendAsync(row.Cells[2].Value.ToString(),txt_subject.Text, txt_content.Text);
            }

            MessageBox.Show("Đã gửi xong.", "Thành công");

        }

        private void btn_manage_department_Click(object sender, EventArgs e)
        {
            new DepartmentManage().Show();
        }

        private void btn_manage_employee_Click(object sender, EventArgs e)
        {
            new EmployeeManage().Show();
        }

        private void btn_mailbox_Click(object sender, EventArgs e)
        {
            new MailBox().Show();
        }
    }
}
