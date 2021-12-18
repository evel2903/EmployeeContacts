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
    public partial class EmployeeManage : Form
    {
        private EmployeeServices employeeServices;
        private DepartmentServices departmentServices;
        public EmployeeManage()
        {
            InitializeComponent();
            employeeServices = new EmployeeServices();
            departmentServices = new DepartmentServices();
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
                row.Cells[2].Value = _e.EmployeeDob;
                row.Cells[3].Value = _e.EmployeeGender;
                row.Cells[4].Value = _e.EmployeeEmail;
                row.Cells[5].Value = _e.EmployeePhone;
                row.Cells[6].Value = _e.EmployeeState;
                row.Cells[7].Value = _e.EmployeeChangeDepartment;
                row.Cells[8].Value = departmentServices.GetById(_e.DepartmentId).DepartmentName;

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
                row.Cells[2].Value = _e.EmployeeDob;
                row.Cells[3].Value = _e.EmployeeGender;
                row.Cells[4].Value = _e.EmployeeEmail;
                row.Cells[5].Value = _e.EmployeePhone;
                row.Cells[6].Value = _e.EmployeeState;
                row.Cells[7].Value = _e.EmployeeChangeDepartment;
                row.Cells[8].Value = departmentServices.GetById(_e.DepartmentId).DepartmentName;

                table_employees.Rows.Add(row);
            });
        }
        private void loadDepartmentFilter()
        {
            txt_filter_department.Items.Add("0 - Get All");

            List<Department> departments = departmentServices.GetAll();
            departments.ForEach(_d =>
            {
                txt_filter_department.Items.Add(_d.DepartmentId + " - " + _d.DepartmentName);
                cb_department.Items.Add(_d.DepartmentId + " - " + _d.DepartmentName);
            });
            txt_filter_department.SelectedIndex = 0;
        }

        private void txt_filter_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = txt_filter_department.SelectedItem.ToString();
            int department_id = Int32.Parse(selectedValue.Substring(0, selectedValue.IndexOf(" ")));

            loadDataTable(department_id);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string q = txt_q_employee.Text;
            var list = employeeServices.FilterByName(q);
            loadDataTable(list);
        }

        private void txt_q_employee_Click(object sender, EventArgs e)
        {
            txt_filter_department.SelectedIndex = 0;
        }

        private void table_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                changeEnableButton(true);
                DataGridViewRow selected = table_employees.Rows[e.RowIndex];
                txt_id.Text = selected.Cells[0].Value.ToString();
                txt_fullname.Text = selected.Cells[1].Value.ToString();
                dt_dob.Value = DateTime.Parse(selected.Cells[2].Value.ToString());
                cb_gender.SelectedIndex = selected.Cells[3].Value.ToString().Equals("Nam") ? 0 : 1;
                txt_email.Text = selected.Cells[4].Value.ToString();
                txt_pnumber.Text = selected.Cells[5].Value.ToString();
                txt_status.Text = selected.Cells[6].Value.ToString();
                txt_change.Text = selected.Cells[7].Value.ToString();

                foreach(var item in cb_department.Items)
                {
                    string itemNameDepartment = item.ToString().Substring(item.ToString().IndexOf(" "));
                    if (itemNameDepartment.Equals(" - " + selected.Cells[8].Value.ToString())){
                        cb_department.SelectedItem = item;
                        return;
                    }
                }
            }
        }
        private void changeEnableButton(bool state)
        {

            btn_edt.Enabled = state;
            btn_delete.Enabled = state;
            btn_endwork.Enabled = state;
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            /*
            txt_id.Text = selected.Cells[0].Value.ToString();
            txt_fullname.Text = selected.Cells[1].Value.ToString();
            dt_dob.Value = DateTime.Parse(selected.Cells[2].Value.ToString());
            cb_gender.SelectedIndex = selected.Cells[3].Value.ToString().Equals("Nam") ? 0 : 1;
            txt_email.Text = selected.Cells[4].Value.ToString();
            txt_pnumber.Text = selected.Cells[5].Value.ToString();
            txt_status.Text = selected.Cells[6].Value.ToString();
            txt_change.Text = selected.Cells[7].Value.ToString();
            */

            Employee employee = new Employee();
            employee.EmployeeId = 0;
            employee.EmployeeFullname = txt_fullname.Text;
            employee.EmployeeDob = dt_dob.Value;
            employee.EmployeeGender = cb_gender.SelectedItem.ToString();
            employee.EmployeeEmail = txt_email.Text;
            employee.EmployeePhone = txt_pnumber.Text;
            employee.EmployeeState = "Đang làm việc";
            employee.EmployeeChangeDepartment = "Không";
            employee.DepartmentId = Int32.Parse(cb_department.SelectedItem.ToString().Substring(0, cb_department.SelectedItem.ToString().IndexOf(" ")));

            employeeServices.Create(employee);

            changeEnableButton(false);
            loadDataTable(0);
            txt_id.Text = "";
            txt_fullname.Text = "";
            dt_dob.Value = DateTime.Now;
            cb_gender.SelectedIndex = 0;
            txt_email.Text = "";
            txt_pnumber.Text = "";
            txt_status.Text = "";
            txt_change.Text = "";
            cb_department.SelectedIndex = 0;
        }

        private void btn_edt_Click(object sender, EventArgs e)
        {
            int _d_id = Int32.Parse(cb_department.SelectedItem.ToString().Substring(0, cb_department.SelectedItem.ToString().IndexOf(" ")));
            Employee employee = new Employee();
            employee.EmployeeId = Int32.Parse(txt_id.Text);
            employee.EmployeeFullname = txt_fullname.Text;
            employee.EmployeeDob = dt_dob.Value;
            employee.EmployeeGender = cb_gender.SelectedItem.ToString();
            employee.EmployeeEmail = txt_email.Text;
            employee.EmployeePhone = txt_pnumber.Text;
            employee.EmployeeState = txt_status.Text;
            employee.EmployeeChangeDepartment = "Không";
            employee.DepartmentId = _d_id ;

            employeeServices.Edit(employee);

            changeEnableButton(false);
            loadDataTable(0);
            txt_id.Text = "";
            txt_fullname.Text = "";
            dt_dob.Value = DateTime.Now;
            cb_gender.SelectedIndex = 0;
            txt_email.Text = "";
            txt_pnumber.Text = "";
            txt_status.Text = "";
            txt_change.Text = "";
            cb_department.SelectedIndex = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            employeeServices.Delete(Int32.Parse(txt_id.Text));

            changeEnableButton(false);
            loadDataTable(0);
            txt_id.Text = "";
            txt_fullname.Text = "";
            dt_dob.Value = DateTime.Now;
            cb_gender.SelectedIndex = 0;
            txt_email.Text = "";
            txt_pnumber.Text = "";
            txt_status.Text = "";
            txt_change.Text = "";
            cb_department.SelectedIndex = 0;
        }

        private void btn_endwork_Click(object sender, EventArgs e)
        {
            employeeServices.EndWork(Int32.Parse(txt_id.Text));

            changeEnableButton(false);
            loadDataTable(0);
            txt_id.Text = "";
            txt_fullname.Text = "";
            dt_dob.Value = DateTime.Now;
            cb_gender.SelectedIndex = 0;
            txt_email.Text = "";
            txt_pnumber.Text = "";
            txt_status.Text = "";
            txt_change.Text = "";
            cb_department.SelectedIndex = 0;
        }
    }
}
