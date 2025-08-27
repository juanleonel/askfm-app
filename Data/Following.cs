namespace askfm.Data
{
    public class Following
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } = null;
        public string FollowingUserId { get; set; }
    }
}
