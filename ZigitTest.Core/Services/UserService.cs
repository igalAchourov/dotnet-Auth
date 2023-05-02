using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigitTest.Domain.Models;
using ZigitTest.Core.Interfaces;
using ZigitTest.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using ZigitTest.Domain.DTOs;

namespace ZigitTest.Core.Services
{
    public class UserService : IUsersService
    {
        private readonly ZigitTestDbContext _context;
        public UserService(ZigitTestDbContext context)
        {
            _context = context;
        }
        public async Task<List<Project>> GetProjects(int id)
        {
            List<Project> projects = await _context.Projects.Where(x => x.UserId == id).ToListAsync();
            return projects;
        }

        
    }
}
