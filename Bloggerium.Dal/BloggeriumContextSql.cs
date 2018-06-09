using Bloggerium.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bloggerium.Dal
{
    public class BloggeriumContextSql : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlConfig.ConnectionString);
        }
    }
}