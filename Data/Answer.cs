namespace askfm.Data
{
    public class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int CommentId { get; set; }
        public Comment Comment { get; set; } = null;
    }
}
