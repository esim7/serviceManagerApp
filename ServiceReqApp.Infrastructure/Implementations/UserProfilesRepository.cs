using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.DataAccess;
using ServiceReqApp.Domain;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.Infrastructure.Implementations
{
    public class UserProfilesRepository : IRepository<UserProfile>
    {
        private readonly ApplicationDbContext _context;

        public UserProfilesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<UserProfile>> GetAllAsync()
        {
            return await _context.UserProfiles.Include(u => u.User).ToListAsync();
        }

        public async Task<UserProfile> GetByIdAsync(int? id)
        {
            return await _context.UserProfiles.Include(u => u.User)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<UserProfile> CreateAsync(UserProfile entity)
        {
            var createdUserProfile = await _context.UserProfiles.AddAsync(entity);
            return createdUserProfile.Entity;
        }

        public async Task<UserProfile> UpdateAsync(UserProfile entity)
        {
            var updatedUserProfile = _context.UserProfiles.Update(entity);
            return updatedUserProfile.Entity;
        }

        public async Task<UserProfile> RemoveAsync(int? id)
        {
            var deletedUserProfile = await _context.UserProfiles.FindAsync(id);
            _context.UserProfiles.Remove(deletedUserProfile);
            return deletedUserProfile;
        }
    }
}