namespace askfm.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsAnonymous { get; set; }
        public bool IsActive { get; set; }
        public string FromUserId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public IList<AnswerModel> Answers { get; set; }
    }
}
