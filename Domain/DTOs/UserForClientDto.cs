using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigitTest.Domain.Models;

namespace ZigitTest.Domain.DTOs
{
    public class UserForClientDto
    {
        public string FullName { get; set; }
        public string Team { get; set; }
        public string Avatar { get; set; }
        public DateTime JoinedAt { get; set; }
    }
}
