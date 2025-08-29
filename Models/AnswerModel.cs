using askfm.Data;

namespace askfm.Models
{
    public class AnswerModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public object User { get; set; }
        public string FollowerUserId { get; set; }
    }
}
