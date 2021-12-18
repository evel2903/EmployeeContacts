using EmployeeContacts.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeContacts.Services.Employees
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly ManageEmployeeContactsContext _context;
        public EmployeeServices()
        {
            _context = new ManageEmployeeContactsContext();
        }
        public Employee ChangeDepartment(int id, int department_id)
        {
            var _employee = _context.Employees.FirstOrDefault(_e => _e.EmployeeId == id);
            var _department = _context.Departments.FirstOrDefault(_d => _d.DepartmentId == department_id);
            if(_employee == null || _department == null) 
            {
                return null;
            }
            _employee.DepartmentId = department_id;
            _employee.EmployeeChangeDepartment = "Chuyển từ phòng " + _department.DepartmentName;
            _context.Employees.Update(_employee);
            _context.SaveChanges();
            return _employee;
        }

        public Employee Create(Employee employee)
        {
            employee.EmployeeId = 0;
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return _context.Employees.ToList().Last();

        }

        public Employee Delete(int id)
        {
            var _employee = _context.Employees.FirstOrDefault(_e => _e.EmployeeId == id);
            if(_employee == null)
            {
                return null;
            }
            _context.Employees.Remove(_employee);
            _context.SaveChanges();
            return _employee;
        }

        public Employee Edit(Employee employee)
        {
            var _employee = _context.Employees.FirstOrDefault(_e => _e.EmployeeId == employee.EmployeeId);
            if(_employee == null)
            {
                return null;
            }
            _employee.EmployeeFullname = employee.EmployeeFullname;
            _employee.EmployeeDob = employee.EmployeeDob;
            _employee.EmployeeGender = employee.EmployeeGender;
            _employee.EmployeeEmail = employee.EmployeeEmail;
            _employee.EmployeePhone = employee.EmployeePhone;
            _employee.EmployeeState = employee.EmployeeState;
            _employee.EmployeeChangeDepartment = employee.DepartmentId != _employee.DepartmentId ? "Chuyển từ " + _context.Departments.First(_d => _d.DepartmentId == employee.DepartmentId).DepartmentName : "Không";
            _employee.DepartmentId = employee.DepartmentId;
            _context.SaveChanges();
            return _employee;
        }

        public Employee EndWork(int id)
        {
            var employee = _context.Employees.FirstOrDefault(_e => _e.EmployeeId == id);
            if (employee == null)
            {
                return null;
            }
            employee.EmployeeState = "Đã nghỉ việc";
            _context.Employees.Update(employee);
            return employee;
        }

        public List<Employee> FilterByName(string name)
        {
            var list = _context.Employees.Where(_e => _e.EmployeeFullname.Contains(name)).ToList();
            return list;
        }

        public List<Employee> GetAll()
        {
            var list = _context.Employees.ToList();
            return list;
        }
    }
}
