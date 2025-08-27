using askfm.Data;
using askfm.Models;

namespace askfm.Utils
{
    public class UserMapper
    {
        public ApplicationUser ToEntity(ApplicationUser Model)
        {
            ApplicationUser Entity = new ApplicationUser();

            if (Model.Id != null) Entity.Id = Model.Id;
            if (Model.UserName != null) Entity.UserName = Model.UserName;
            if (Model.LastName != null) Entity.LastName = Model.LastName;
            if (Model.Email != null) Entity.Email = Model.Email;
            //if (Model.IsActive != null) CommentEntity.IsActive = Model.IsActive;
            //if (Model.CreatedAt != null) CommentEntity.CreatedAt = Model.CreatedAt;

            return Entity;
        }

        public UserModel ToModel(ApplicationUser Entity)
        {
            UserModel Model = new UserModel();

            if (Entity.Id != null) Model.Id = Entity.Id;
            if (Entity.LastName != null) Model.LastName = Entity.LastName;
            if (Entity.UserName != null) Model.UserName = Entity.UserName;
            if (Entity.Email != null) Model.Email = Entity.Email;
            //if (Entity.CreatedAt != null) Model.CreatedAt = Entity.CreatedAt;

            return Model;
        }
    }
}
