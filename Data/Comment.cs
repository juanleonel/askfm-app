namespace askfm.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } = null;
        public bool IsAnonymous { get; set; }
        public bool IsActive { get; set; }
        public string FromUserId { get; set; }
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}