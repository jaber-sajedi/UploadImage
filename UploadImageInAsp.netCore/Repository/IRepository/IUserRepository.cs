using UploadImageInAsp.netCore.Models;

namespace UploadImageInAsp.netCore.Repository.IRepository
{
    public interface IUserRepository:IRepository<User>
    {
         void Update(User obj);
    }
}
