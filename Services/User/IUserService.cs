using AspnetIdentityRoleBasedTutorial.Data;

namespace AspnetIdentityRoleBasedTutorial.Services.User
{
    public interface IUserService
    {
        public  Task<List<ApplicationUser>> GetAll();
        public  Task<ApplicationUser> GetById(int id);
    }
}
