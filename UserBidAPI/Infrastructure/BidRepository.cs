using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UserBidAPI.DomainServices;
using UserBidAPI.Model;

namespace UserBidAPI.Infrastructure
{
    public class BidRepository : IRepository<Bid>
    {
        private readonly ConcurrentDictionary<int, Bid> _bids = new ConcurrentDictionary<int, Bid>();
        private int _bidsAmount = 1;
        private readonly object _lockObject = new object();
        public void Add(Bid bid)
        {

            lock (_lockObject)
            {
                bid.Id = _bidsAmount;
                _bids.TryAdd(_bidsAmount, bid);
                Interlocked.Increment(ref _bidsAmount);
            }
        }

        public Bid Get(string name)
        {
            throw new NotImplementedException();
        }

        public Bid Get(int id)
        {
            var user = _bids[id];
            return user;
        }

        public IList<Bid> Get()
        {
            var bids = _bids.Values.ToList();
            return bids;
        }
    }
}