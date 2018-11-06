using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UserBidAPI.DomainServices;
using UserBidAPI.DTO;
using UserBidAPI.Presentation;

namespace UserBidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBidController : ControllerBase
    {
        private readonly IUserBidService _userBidService;
        private readonly IUserBidPresenter _userBidPresenter;

        public UserBidController(IUserBidService userBidService,
            IUserBidPresenter userBidPresenter)
        {
            _userBidService = userBidService;
            _userBidPresenter = userBidPresenter;
        }

        // GET: api/userbid
        [HttpGet()]
        public IEnumerable<UserBidsViewModel> Get()
        {
            var users = _userBidPresenter.Get();
            return users;
        }

        // POST: api/Bid
        [HttpPost]
        public void Post([FromBody] UserBidDto dto)
        {
            _userBidService.Place(dto);
        }
    }
}