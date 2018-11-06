using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UserBidAPI.DomainServices;
using UserBidAPI.Model;

namespace UserBidAPI.Infrastructure
{
    public class UserBidRepository : IRepository<UserBid>
    {
        private readonly ConcurrentDictionary<int, UserBid> _userBids = new ConcurrentDictionary<int, UserBid>();
        private int _userBidsAmount = 1;
        private readonly object _lockObject = new object();

        public void Add(UserBid userBid)
        {
            lock (_lockObject)
            {
                userBid.Id = _userBidsAmount;
                _userBids.TryAdd(_userBidsAmount, userBid);
                Interlocked.Increment(ref _userBidsAmount);
            }
        }

        public UserBid Get(string name)
        {
            throw new NotImplementedException();
        }

        public UserBid Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<UserBid> Get()
        {
            var userBids = _userBids.Values.ToList();
            return userBids;
        }
    }
}