using EmployeeContacts.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeContacts.Services.Departments
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly ManageEmployeeContactsContext _context;
        public DepartmentServices()
        {
            _context = new ManageEmployeeContactsContext();
        }

        public Department Create(Department department)
        {
            department.DepartmentId = 0;
            _context.Departments.Add(department);
            _context.SaveChanges();
            return _context.Departments.ToList().Last();
        }

        public Department Delete(int id)
        {
            var department = _context.Departments.First(_d => _d.DepartmentId == id);
            if (department == null)
            {
                return null;
            }

            var employees = _context.Employees.Where(_e => _e.DepartmentId == id).ToList();
            employees.ForEach(_e => _context.Employees.Remove(_e));

            _context.Departments.Remove(department);
            _context.SaveChanges();
            return department;
        }

        public Department Edit(Department department)
        {
            var _department = _context.Departments.First(_d => _d.DepartmentId == department.DepartmentId);
            if (_department == null)
            {
                return null;
            }
            _department.DepartmentName = department.DepartmentName;
            _context.SaveChanges();
            return _department;
        }

        public List<Department> FindByName(string q)
        {
            var list = _context.Departments.Where(_e => _e.DepartmentName.Contains(q)).ToList();
            return list;
        }

        public List<Department> GetAll()
        {
            var list = _context.Departments.ToList();
            return list;
        }

        public Department GetById(int id)
        {
            var department = _context.Departments.First(_d => _d.DepartmentId == id);
            if (department == null)
            {
                return null;
            }
            return department;
        }

        public List<Employee> GetEmployees(int id)
        {
            var list = _context.Employees.Where(_e => _e.DepartmentId == id).ToList();
            return list;
        }
    }
}
