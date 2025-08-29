using askfm.Data;
using askfm.Interfaces;
using askfm.Models;
using askfm.Utils;
using Microsoft.EntityFrameworkCore;

namespace askfm.Services
{
    public class UserService : IUser
    {
        private readonly ApplicationDbContext _context;
        private readonly UserMapper Mapper;
        public UserService(ApplicationDbContext context)
        {
            this._context = context;
            this.Mapper = new UserMapper();
        }

        public Task Add(UserModel User)
        {
            throw new NotImplementedException();
        }

        public Task Delete(UserModel User)
        {
            throw new NotImplementedException();
        }

        public async Task<UserModel> GetById(string Id)
        {
            var Result = await _context.Users.FindAsync(Id);

            return this.Mapper.ToModel(Result);
        }

        public async Task<IEnumerable<UserModel>> GetUsers(string Query)
        {
            var Result = await _context.Users.Where(Item => Item.LastName.Contains(Query) || Item.UserName.Contains(Query)).ToListAsync();

            return Result.Select(Item => this.Mapper.ToModel(Item));
        }

        public Task Update(UserModel User)
        {
            throw new NotImplementedException();
        }
    }
}
