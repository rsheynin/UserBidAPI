using Microsoft.AspNetCore.Mvc;
using UserBidAPI.DomainServices;
using UserBidAPI.DTO;

namespace UserBidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        private readonly IBidService _bidService;

        public BidController(IBidService bidService)
        {
            _bidService = bidService;
        }


        // POST: api/Bid
        [HttpPost]
        public void Post([FromBody] BidDto dto)
        {
            _bidService.Add(dto);
        }
    }
}