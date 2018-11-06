using System.Collections.Generic;
using UserBidAPI.Controllers;

namespace UserBidAPI.Presentation
{
    public interface IUserBidPresenter
    {
        IEnumerable<UserBidsViewModel> Get();
    }
}