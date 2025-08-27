using askfm.Data;
using askfm.Interfaces;
using askfm.Models;
using askfm.Utils;
using Microsoft.EntityFrameworkCore;

namespace askfm.Services
{
    public class CommentService : IComment
    {
        private readonly ApplicationDbContext _context;
        private readonly CommentMapper Mapper;
        public CommentService(ApplicationDbContext context)
        {
            this._context = context;
            this.Mapper = new CommentMapper();
        }

        public async Task Add(CommentModel Comment)
        {
            Comment Entity = new Comment();
            Entity.CreatedAt = DateTime.Now;
            Entity.Content = Comment.Content;
            Entity.IsAnonymous = Comment.IsAnonymous;
            Entity.IsActive = true;
            await _context.Comments.AddAsync(Entity);
            await _context.SaveChangesAsync();
        }

        public Task Delete(CommentModel Comment)
        {
            throw new NotImplementedException();
        }

        public Task<CommentModel> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CommentModel>> GetComments(int UserId)
        {
            var Comments = await _context.Comments.Where(Item => Item.IsActive).ToListAsync();

            return Comments.Select(Item => this.Mapper.ToModel(Item));
        }

        public Task Update(CommentModel Comment)
        {
            throw new NotImplementedException();
        }
    }
}
