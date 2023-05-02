using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigitTest.Domain.DTOs;
using ZigitTest.Domain.Models;

namespace ZigitTest.Domain.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForLoginDto>();
            CreateMap<User, UserForClientDto>();
        }
    }
}
