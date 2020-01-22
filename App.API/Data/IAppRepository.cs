using System.Collections.Generic;
using System.Threading.Tasks;
using App.API.Models;
using App.API.Helpers;

namespace App.API.Data
{
    public interface IAppRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAll();

         Task<PagedList<User>> GetUsers(UserParams userParams);

        Task<User> GetUser(int id);   

        Task<Photo> GetPhoto(int id);

        Task<Photo> GetMainPhotoForUser(int userId);
        Task<Like> GetLike(int userId, int recipientId);

        Task<Message1>GetMessage(int id);

        Task<PagedList<Message1>> GetMessagesForUser(MessageParams messageParams);

        Task<IEnumerable<Message1>>GetMessageThread(int userId, int recipientId);
    }
}