using System.Collections.Generic;
using System.Linq;
using UserBidAPI.Controllers;
using UserBidAPI.DomainServices;
using UserBidAPI.Model;

namespace UserBidAPI.Presentation
{
    public class UserBidPresenter : IUserBidPresenter
    {
        private readonly IRepository<UserBid> _userBidRepository;
        private readonly IRepository<Bid> _bidRepository;
        private readonly IRepository<User> _useRepository;

        public UserBidPresenter(
            IRepository<UserBid> userBidRepository,
            IRepository<Bid> bidRepository,
            IRepository<User> useRepository)
        {
            _userBidRepository = userBidRepository;
            _bidRepository = bidRepository;
            _useRepository = useRepository;
        }

        public IEnumerable<UserBidsViewModel> Get()
        {
            var userBids = _userBidRepository.Get();
            var users = _useRepository.Get();
            var bids = _bidRepository.Get();

            var userBidsViewModel = (from userBid in userBids
                join bid in bids on userBid.BidId equals bid.Id
                join user in users on userBid.UserId equals user.Id
                select new UserBidsViewModel
                {
                    BidName = bid.Name,
                    UserName = user.Name,
                    SuggestedPrice = userBid.SuggestedPrice,
                });

            return userBidsViewModel;
        }

    }
}