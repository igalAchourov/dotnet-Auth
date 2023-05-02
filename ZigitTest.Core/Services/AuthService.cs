using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigitTest.Domain.Models;
using ZigitTest.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using ZigitTest.DataAccess.Persistence;

namespace ZigitTest.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly ZigitTestDbContext _context;
        public AuthService(ZigitTestDbContext context)
        {
            _context = context;
        }
        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users.Include(p=>p.Projects).FirstOrDefaultAsync(x => x.UserName == username);
            if (user == null)
            {
                return null;
            }
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }
            return user;
        }


        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {

            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;


        }
    }
}
