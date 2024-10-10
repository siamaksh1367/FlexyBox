using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;
using FlexyBox.dal.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace FlexyBox.dal.Repositories.Implementation
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(DbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Post>> GetAllPostsIncludingDetailsAsync()
        {
            return await _dbSet
                .Include(x => x.Category)
                .Include(x => x.Tags)
                .Include(x => x.Comments)
                .ToListAsync();
        }
    }
}
