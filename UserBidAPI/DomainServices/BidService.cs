using System.Collections.Generic;
using UserBidAPI.DTO;
using UserBidAPI.Model;

namespace UserBidAPI.DomainServices
{
    public class BidService : IBidService
    {
        private readonly IRepository<Bid> _repository;

        public BidService(IRepository<Bid> repository)
        {
            _repository = repository;
        }

        public void Add(BidDto bidDto)
        {
            var bid = new Bid(bidDto.Name);
            _repository.Add(bid);
        }

        public Bid Get(int id)
        {
            var bid = _repository.Get(id);
            return bid;
        }

        public IList<Bid> Get()
        {
            var bids = _repository.Get();
            return bids;
        }
    }
}