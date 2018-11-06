using UserBidAPI.DTO;
using UserBidAPI.Model;

namespace UserBidAPI.DomainServices
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public void Add(UserDto userDto)
        {
            var user = new User(userDto.Name);
            _repository.Add(user);
        }

        public User Get(string name)
        {
            var user = _repository.Get(name);
            return user;
        }
    }
}