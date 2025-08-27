using askfm.Models;

namespace askfm.Interfaces
{
    public interface IComment
    {
        Task Add(CommentModel Comment);
        Task Update(CommentModel Comment);
        Task Delete(CommentModel Comment);
        Task<CommentModel> GetById(int Id);
        Task<IEnumerable<CommentModel>> GetComments(int UserId);
    }
}
