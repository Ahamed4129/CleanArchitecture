using cleanarchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanarchitecture.Application.Command
{
    public class CreateEmployeeCommand : IRequest<Employee>
    {
        public string Name {  get; set; }
    }
}
    