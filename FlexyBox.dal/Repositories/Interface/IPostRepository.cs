using FlexyBox.common;
using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;

namespace FlexyBox.dal.Repositories.Interface
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Task<WithCount<Post>> GetPosts(List<int>? tagIds, string? userId, int categoryId, int offset, int limit);
        Task<Post> GetPostWithDetails(int Id);
    }

}
