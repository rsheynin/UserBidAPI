using System;
using System.Collections.Generic;
using UserBidAPI.DTO;
using UserBidAPI.Model;

namespace UserBidAPI.DomainServices
{
    public class UserBidService : IUserBidService
    {
        private readonly IRepository<UserBid> _userBidRepository;

        public UserBidService(IRepository<UserBid> userBidRepository)
        {
            _userBidRepository = userBidRepository;
        }

        public IList<UserBid> Get()
        {
            var userBids = _userBidRepository.Get();

            return userBids;
        }

        public void Place(UserBidDto userBidDto)
        {
            //validation should come here 

            var userBid = new UserBid(userBidDto.BidId, userBidDto.UserId, userBidDto.SuggestedPrice);
            _userBidRepository.Add(userBid);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}