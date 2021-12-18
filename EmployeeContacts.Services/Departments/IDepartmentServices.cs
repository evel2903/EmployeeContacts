using EmployeeContacts.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeContacts.Services.Departments
{
    public interface IDepartmentServices
    {
        List<Department> GetAll();
        Department Create(Department department);
        Department Edit(Department department);
        Department Delete(int id);
        List<Employee> GetEmployees(int id);
        Department GetById(int id);
        List<Department> FindByName(string q);

    }
}
