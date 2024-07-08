using cleanarchitecture.Domain.Entities;
using cleanarchitecture.Domain.Interface;
using cleanarchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanarchitecture.Infrastructure.Repository
{
    public class EmployeeRepository :   IEmployee
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeRepository(EmployeeDbContext employeeDbContext) 
        { 
            _employeeDbContext = employeeDbContext;
        }
        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> CreateAsync(Employee employee)
        {
            await _employeeDbContext.employees.AddAsync(employee);
            await _employeeDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _employeeDbContext.employees.FindAsync(id);
            if (entity == null)
                return false;

            _employeeDbContext.employees.Remove(entity);
            await _employeeDbContext.SaveChangesAsync();
            return true;
            
        }

        public async Task<List<Employee>> GetAllAsync()
        {
           return await _employeeDbContext.employees.ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _employeeDbContext.employees.FindAsync(id);
        }




        public async Task<Employee> UpdateAsync(int id, Employee employee)
        {
            var existingEmployee = await _employeeDbContext.employees.FindAsync(id);
            if (existingEmployee == null)
                return null;

            // Update properties
            existingEmployee.Name = employee.Name;
            // Update other properties as needed

            _employeeDbContext.employees.Update(existingEmployee);
            await _employeeDbContext.SaveChangesAsync();
            return existingEmployee;
        }
    }
}
