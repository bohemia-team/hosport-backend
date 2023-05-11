using AspnetIdentityRoleBasedTutorial.Data;
using Microsoft.AspNetCore.Identity;

namespace AspnetIdentityRoleBasedTutorial.Services.User
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _context;

        public UserService(UserManager<ApplicationUser> context)
        {
            _context = context;
        }

        public async Task<List<ApplicationUser>> GetAll()
        {
            var users = _context.Users;
            return  users.ToList();
        }

        public async Task<ApplicationUser> GetById(int id)
        {
            return await _context.FindByIdAsync(id.ToString());
        }


    }
}
