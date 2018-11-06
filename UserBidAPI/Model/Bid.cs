namespace UserBidAPI.Model
{
    public class Bid
    {
        public Bid(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}