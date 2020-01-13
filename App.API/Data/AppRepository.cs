using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.API.Models;
using Microsoft.EntityFrameworkCore;
using App.API.Helpers;

namespace App.API.Data
{
    public class AppRepository: IAppRepository
{
        private readonly DataContext _context;
        public AppRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p=>p.Photos).FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<PagedList<User>> GetUsers(UserParams userParams)
        {
            var users = _context.Users.Include(p => p.Photos)
                .OrderByDescending(u => u.LastActive).AsQueryable();

            users = users.Where(u => u.Id != userParams.UserId);

            users = users.Where(u => u.Type == userParams.Type);

            if (userParams.Country != null){
            
              users = users.Where(u => u.Country == userParams.Country);
            }  

            if (userParams.City!= null){
            
                users = users.Where(u => u.City == userParams.City);
            }

            if (!string.IsNullOrEmpty(userParams.OrderBy))
            {
                switch (userParams.OrderBy)
                {
                    case "createdAt":
                        users = users.OrderByDescending(u=> u.CreatedAt);
                        break;
                    default:
                        users = users.OrderByDescending(u=> u.LastActive);
                        break;  
                }
            }

            return await PagedList<User>.CreateAsync(users, userParams.PageNumber, userParams.PageSize);
        }

        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(photo=> photo.Id==id);

            return photo;
        }

        public async Task<Photo>GetMainPhotoForUser(int userId){
            return await _context.Photos.Where(u => u.UserId == userId).FirstOrDefaultAsync(p=>p.IsMain);
        }

}
}