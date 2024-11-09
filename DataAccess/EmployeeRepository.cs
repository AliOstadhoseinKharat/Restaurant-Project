using DataAccess.Services;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly RestaurantContext _dbContext;

        public EmployeeRepository()
        {
            this._dbContext = new RestaurantContext();
        }

        public int Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            return employee.EmployeeID;
        }

        public Employee Get(int EmployeeID)
        {
            Employee emp = _dbContext.Employees.FirstOrDefault(item => item.EmployeeID == EmployeeID);
            return emp;
        }

        public List<Employee> GetAll()
        {
            return _dbContext.Employees.ToList();
        }

        public bool Remove(int EmployeeID)
        {

            bool result = false;
            try
            {
                Employee emp = _dbContext.Employees.FirstOrDefault(item => item.EmployeeID == EmployeeID);
                _dbContext.Employees.Remove(emp);
                _dbContext.SaveChanges();
                result = true;

            }
            catch
            {

                result = false;
            }
            return result;

        }

        public bool Update(Employee newEmployee)
        {
            bool result = false;
            try
            {
                var oldEmployee = _dbContext.Employees.FirstOrDefault(item => item.EmployeeID == newEmployee.EmployeeID);
                oldEmployee.FirstName = newEmployee.FirstName;
                oldEmployee.LastName = newEmployee.LastName;
                oldEmployee.UserName = newEmployee.UserName;
                oldEmployee.Password = newEmployee.Password;
                oldEmployee.IsActive = newEmployee.IsActive;

                _dbContext.SaveChanges();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
