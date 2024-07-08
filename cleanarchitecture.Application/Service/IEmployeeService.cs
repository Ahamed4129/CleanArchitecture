        using cleanarchitecture.Domain.Entities;
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace cleanarchitecture.Application.Service
        {
            public interface IEmployeeService
            {
                Task<Employee> GetByIdAsync(int id);
                Task<List<Employee>> GetAllAsync();
                Task<int> CountAsync();
                Task<Employee> CreateAsync(Employee employee);
                Task<int> UpdateAsync(int id, Employee employee);
                Task<bool> DeleteAsync(int id);
            }
        }
