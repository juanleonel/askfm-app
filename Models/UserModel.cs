namespace askfm.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public IList<CommentModel> Comments { get; set; }
    }
}
