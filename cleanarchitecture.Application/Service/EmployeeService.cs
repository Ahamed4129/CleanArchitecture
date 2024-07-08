using cleanarchitecture.Domain.Entities;
using cleanarchitecture.Domain.Interface;
using cleanarchitecture.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanarchitecture.Application.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployee _employeerepository;
        public EmployeeService(IEmployee employeerepository)
        {
            _employeerepository=employeerepository;
        }
        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> CreateAsync(Employee employee)
        {
          return await _employeerepository.CreateAsync(employee);
        }

        public async Task<bool> DeleteAsync(int id)
        {
           return await _employeerepository.DeleteAsync(id);
        }

        public async  Task<List<Employee>> GetAllAsync()
        {
          return await _employeerepository.GetAllAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
           return await _employeerepository.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(int id, Employee employee)
        {
            var existingEmployee = await _employeerepository.GetByIdAsync(id);
            if (existingEmployee == null)
            {
                return 0; // Employee not found
            }
            existingEmployee.Name = employee.Name;

            var updatedEmployee = await _employeerepository.UpdateAsync(id, existingEmployee);
            return updatedEmployee.Id;
        }
    }
}

