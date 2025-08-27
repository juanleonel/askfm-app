using askfm.Data;
using askfm.Models;

namespace askfm.Interfaces
{
    public interface IUser
    {
        Task Add(UserModel User);
        Task Update(UserModel User);
        Task Delete(UserModel User);
        Task<UserModel> GetById(string Id);
        Task<IEnumerable<UserModel>> GetUsers(string Query);
    }
}
