using cleanarchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanarchitecture.Application.Quries
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {      
        public int Id { get; set; }
    }
    
}
