using cleanarchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace cleanarchitecture.Domain.Interface
{
    public interface IEmployee
    {
        Task<Employee> GetByIdAsync(int id);
        Task<List<Employee>> GetAllAsync();
        Task<int> CountAsync();
        Task<Employee> CreateAsync(Employee employee);
        Task<Employee> UpdateAsync (int id, Employee employee );
        Task<bool> DeleteAsync(int id);
       
    }
}
