using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigitTest.Domain.Models;

namespace ZigitTest.Domain.Models
{
    public  class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FullName { get; set; }
        public string Team { get; set; }
        public string Avatar { get; set; }
        public DateTime JoinedAt { get; set; }
        public List<Project> Projects { get; set; }
    }
}
