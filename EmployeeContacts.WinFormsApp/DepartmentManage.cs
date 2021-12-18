using EmployeeContacts.Data.Models;
using EmployeeContacts.Services.Departments;
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
    public partial class DepartmentManage : Form 
    {
        private EmployeeServices employeeServices;
        private DepartmentServices departmentServices;
        public DepartmentManage()
        {
            InitializeComponent();
            employeeServices = new EmployeeServices();
            departmentServices = new DepartmentServices();

            loadDataDepartmentTable();
        }

        private void loadDataDepartmentTable()
        {
            table_departments.Rows.Clear();

            List<Department> departments = departmentServices.GetAll();

            departments.ForEach(_d =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(table_departments);
                row.Cells[0].Value = _d.DepartmentId;
                row.Cells[1].Value = _d.DepartmentName;

                table_departments.Rows.Add(row);
            });
        }
        private void loadDataDepartmentTable(string q)
        {
            table_departments.Rows.Clear();

            List<Department> departments = departmentServices.FindByName(q);

            departments.ForEach(_d =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(table_departments);
                row.Cells[0].Value = _d.DepartmentId;
                row.Cells[1].Value = _d.DepartmentName;

                table_departments.Rows.Add(row);
            });
        }
        private void loadDataEmployeeTable(int department_id)
        {
            
            table_employees.Rows.Clear();

            List<Employee> employees = departmentServices.GetEmployees(department_id);

            employees.ForEach(_e =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(table_employees);
                row.Cells[0].Value = _e.EmployeeId;
                row.Cells[1].Value = _e.EmployeeFullname;
                row.Cells[2].Value = _e.EmployeeEmail;
                row.Cells[3].Value = _e.EmployeePhone;
                row.Cells[4].Value = _e.EmployeeState;
                table_employees.Rows.Add(row);
            });
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loadDataDepartmentTable(txt_q_department.Text);
        }
        private void changeEnableButton(bool state)
        {

            btn_edit.Enabled = state;
            btn_delete.Enabled = state;
        }

        private void table_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow selected = table_departments.Rows[e.RowIndex];
                txt_department_id.Text = selected.Cells[0].Value.ToString();
                txt_department_name.Text = selected.Cells[1].Value.ToString();
                loadDataEmployeeTable(Int32.Parse(selected.Cells[0].Value.ToString()));
                changeEnableButton(true);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_department_name.Text.Equals(""))
            {
                MessageBox.Show("Hãy nhập tên phòng ban", "Lỗi nhập liệu");
                return;
            }
            var _d = new Department();
            _d.DepartmentId = 0;
            _d.DepartmentName = txt_department_name.Text;
            departmentServices.Create(_d);
            MessageBox.Show("Thêm mới phòng ban thành công", "Thành công");
            loadDataDepartmentTable();

            txt_department_id.Text = "0";
            txt_department_name.Text = "";
            table_employees.Rows.Clear();
            changeEnableButton(false);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_department_name.Text.Equals(""))
            {
                MessageBox.Show("Hãy nhập tên phòng ban", "Lỗi nhập liệu");
                return;
            }
            var _d = new Department();
            _d.DepartmentId = Int32.Parse(txt_department_id.Text);
            _d.DepartmentName = txt_department_name.Text;
            departmentServices.Edit(_d);
            MessageBox.Show("Cập nhật phòng ban thành công", "Thành công");
            loadDataDepartmentTable();


            txt_department_id.Text = "0";
            txt_department_name.Text = "";
            table_employees.Rows.Clear();
            changeEnableButton(false);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_department_id.Text.Equals("0"))
            {
                MessageBox.Show("Hãy chọn phòng ban cần xóa", "Lỗi nhập liệu");
                return;
            }
            departmentServices.Delete(Int32.Parse(txt_department_id.Text));
            MessageBox.Show("Xóa phòng ban thành công, nhân viên phòng ban này cũng sẽ bị xóa", "Thành công");
            loadDataDepartmentTable();

            txt_department_id.Text = "0";
            txt_department_name.Text = "";
            table_employees.Rows.Clear();
            changeEnableButton(false);
        }
    }
}
