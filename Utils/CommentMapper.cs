using askfm.Data;
using askfm.Models;

namespace askfm.Utils
{
    public class CommentMapper
    {
        public Comment ToEntity(CommentModel Model)
        {
            Comment CommentEntity = new Comment();

            if (Model.Id != null) CommentEntity.Id = Model.Id;
            if (Model.Content != null) CommentEntity.Content = Model.Content;
            if (Model.IsAnonymous != null) CommentEntity.IsAnonymous = Model.IsAnonymous;
            if (Model.IsActive != null) CommentEntity.IsActive = Model.IsActive;
            if (Model.CreatedAt != null) CommentEntity.CreatedAt = Model.CreatedAt;
            //if (Model.Answers != null && Model.Answers.Any()) CommentEntity.Answers = Model.Answers.ToList() as List<dynamic>;

            return CommentEntity;
        }

        public CommentModel ToModel(Comment Entity)
        {
            CommentModel Model = new CommentModel();

            if (Entity.Id != null) Model.Id = Entity.Id;
            if (Entity.Content != null) Model.Content = Entity.Content;
            if (Entity.IsAnonymous != null) Model.IsAnonymous = Entity.IsAnonymous;
            if (Entity.IsActive != null) Model.IsActive = Model.IsActive;
            if (Entity.CreatedAt != null) Model.CreatedAt = Entity.CreatedAt;

            return Model;
        }
    }
}
