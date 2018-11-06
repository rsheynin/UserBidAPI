namespace UserBidAPI.Model
{
    public class UserBidWinner
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BidId { get; set; }
        public string Name { get; set; }
    }
}