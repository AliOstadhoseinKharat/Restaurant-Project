using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IEmployeeRepository
    {
        bool Remove(int EmployeeID);

        Employee Get(int EmployeeID);

        bool Update(Employee employee);

        List<Employee> GetAll();

        int Add(Employee employee);
    }
}
