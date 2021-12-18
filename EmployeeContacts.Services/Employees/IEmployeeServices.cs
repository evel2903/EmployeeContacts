using EmployeeContacts.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeContacts.Services.Employees
{
    public interface IEmployeeServices
    {
        List<Employee> GetAll();
        Employee Create(Employee employee);
        Employee Edit(Employee employee);
        Employee Delete(int id);
        Employee ChangeDepartment(int id, int department_id);
        Employee EndWork(int id);
        List<Employee> FilterByName(string name);

    }
}
