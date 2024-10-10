
using FlexyBox.dal.Repositories.Interface;

namespace FlexyBox.dal.Generic
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository Posts { get; }
        ICommentRepository Comments { get; }
        ITagRepository Tags { get; }
        ICategoryRepository Categories { get; }
        Task<int> CompleteAsync();
    }

}
