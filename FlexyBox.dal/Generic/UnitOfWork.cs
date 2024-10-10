using FlexyBox.dal.Models;
using FlexyBox.dal.Repositories.Implementation;
using FlexyBox.dal.Repositories.Interface;

namespace FlexyBox.dal.Generic
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FlexyBoxDB _context;


        public IPostRepository Posts { get; private set; }
        public ICommentRepository Comments { get; private set; }
        public ITagRepository Tags { get; private set; }
        public ICategoryRepository Categories { get; private set; }

        public UnitOfWork(FlexyBoxDB context)
        {
            _context = context;
            Posts = new PostRepository(_context);
            Comments = new CommentRepository(_context);
            Tags = new TagRepository(_context);
            Categories = new CategoryRepository(_context);
        }


        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
