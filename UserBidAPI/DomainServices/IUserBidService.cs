using System.Collections.Generic;
using UserBidAPI.DTO;
using UserBidAPI.Model;

namespace UserBidAPI.DomainServices
{
    public interface IUserBidService
    {
        IList<UserBid> Get();
        void Place(UserBidDto userBid);
        void Update();
    }
}