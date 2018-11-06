namespace UserBidAPI.Model
{
    public class UserBid
    {
        public UserBid(int bidId, int userId, int suggestedPrice)
        {
            BidId = bidId;
            UserId = userId;
            SuggestedPrice = suggestedPrice;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int BidId { get; set; }
        public int SuggestedPrice { get; set; }
    }
}