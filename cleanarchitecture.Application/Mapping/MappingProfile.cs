using AutoMapper;
using cleanarchitecture.Application.Command;
using cleanarchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanarchitecture.Application.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateEmployeeCommand, Employee>();
        }
    }
}
