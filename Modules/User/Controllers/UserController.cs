using Microsoft.AspNetCore.Mvc;
using UIJP.Modules.User.Entities;
using UIJP.Modules.User.Services;

namespace IUJP.Modules.User
{
    [ApiController]
    [Route("/users")]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpGet]
        public UserEntity GetUsers()
        {
            return _userService.GetUser();
        }
    }
}
