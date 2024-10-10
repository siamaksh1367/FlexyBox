using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;
using FlexyBox.dal.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace FlexyBox.dal.Repositories.Implementation
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context)
        {
        }
    }
}
