using cleanarchitecture.Application.Quries;
using cleanarchitecture.Domain.Entities;
using cleanarchitecture.Domain.Interface;
using cleanarchitecture.Infrastructure.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanarchitecture.Application.Handler
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery,Employee>
    {
        private readonly IEmployee _employeeRepository;

        public GetEmployeeByIdQueryHandler(IEmployee employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetByIdAsync(request.Id);
        }
    }
}
