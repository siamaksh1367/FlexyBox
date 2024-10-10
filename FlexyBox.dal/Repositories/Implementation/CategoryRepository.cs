using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;
using FlexyBox.dal.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace FlexyBox.dal.Repositories.Implementation
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
