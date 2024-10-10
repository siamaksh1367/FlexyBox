using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;
using FlexyBox.dal.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace FlexyBox.dal.Repositories.Implementation
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(DbContext context) : base(context)
        {
        }
    }
}
