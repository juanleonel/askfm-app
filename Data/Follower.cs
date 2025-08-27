namespace askfm.Data
{
    public class Follower
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } = null;
        public string FollowerUserId { get; set; }
    }
}
