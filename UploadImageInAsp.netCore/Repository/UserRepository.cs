using UploadImageInAsp.netCore.Data;
using UploadImageInAsp.netCore.Models;
using UploadImageInAsp.netCore.Repository.IRepository;

namespace UploadImageInAsp.netCore.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(User obj)
        {
            _db.Users.Update(obj);
        }
    }
}
