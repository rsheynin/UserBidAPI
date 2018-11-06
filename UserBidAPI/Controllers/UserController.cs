using Microsoft.AspNetCore.Mvc;
using UserBidAPI.DomainServices;
using UserBidAPI.DTO;
using UserBidAPI.Model;

namespace UserBidAPI.Controllers
{
    #region Controllers

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/User/username
        [HttpGet("{name}", Name = "Get")]
        public User Get(string name)
        {
            var user = _userService.Get(name);
            return user;
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] UserDto userDto)
        {
            _userService.Add(userDto);
        }
    }

    #endregion

    #region Presentation

    #endregion

    #region Services

    #endregion

    #region Repository

    #endregion

    #region Models

    #endregion

    #region Dto's

    #endregion
}