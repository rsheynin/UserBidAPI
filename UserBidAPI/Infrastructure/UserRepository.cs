using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using UserBidAPI.DomainServices;
using UserBidAPI.Model;

namespace UserBidAPI.Infrastructure
{
    public class UserRepository : IRepository<User>
    {
        private readonly ConcurrentDictionary<string, User> _users = new ConcurrentDictionary<string, User>();
        public void Add(User user)
        {
            _users.AddOrUpdate(user.Name,
                (key) =>
                {
                    user.Id = _users.Count + 1;
                    return user;
                },
                (key, userToUpdate) =>
                {
                    if (user != userToUpdate)
                        throw new ArgumentException("Duplicate user names are not allowed: {0}.", user.Name);

                    return user;
                });
        }

        public User Get(string name)
        {
            var user = _users[name];
            return user;
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> Get()
        {
            var users = _users.Values.ToList();
            return users;
        }
    }
}