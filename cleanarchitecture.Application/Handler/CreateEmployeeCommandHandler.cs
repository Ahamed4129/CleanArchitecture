using AutoMapper;
using cleanarchitecture.Application.Command;
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
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly IEmployee _employeeRepository;
        private readonly IMapper _mapper;
        public CreateEmployeeCommandHandler(IEmployee employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Employee>(request);
            return await _employeeRepository.CreateAsync(employee);
        }

    }
}
