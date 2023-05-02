using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigitTest.Domain.Models;

namespace ZigitTest.Core.Interfaces
{
    public interface IUsersService
    {
        Task <List<Project>> GetProjects (int id);

    }
}
