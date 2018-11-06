namespace UserBidAPI.Model
{
    public class User
    {
        public User(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}