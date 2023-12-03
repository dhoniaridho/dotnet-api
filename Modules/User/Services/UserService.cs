using UIJP.Modules.User.Entities;
namespace UIJP.Modules.User.Services
{
    public interface IUserService
    {
        public UserEntity GetUser();
    }

    public class UserService : IUserService
    {

        public UserEntity GetUser()
        {
            var user = new UserEntity
            {
                Id = 1,
                FullName = "John Doe"
            };

            return user;
        }
    }

}
