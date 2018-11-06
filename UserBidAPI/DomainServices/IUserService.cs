using UserBidAPI.DTO;
using UserBidAPI.Model;

namespace UserBidAPI.DomainServices
{
    public interface IUserService
    {
        void Add(UserDto user);
        User Get(string name);
    }
}