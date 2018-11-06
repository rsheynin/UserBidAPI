using System.Collections.Generic;
using UserBidAPI.DTO;
using UserBidAPI.Model;

namespace UserBidAPI.DomainServices
{
    public interface IBidService
    {
        void Add(BidDto bidDto);
        Bid Get(int id);
        IList<Bid> Get();
    }
}