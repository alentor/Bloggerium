using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bloggerium.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Bloggerium.Dal
{
    public class BloggeriumContext
    {
        private readonly BloggeriumContextSql _BloggeriumContextSql = new BloggeriumContextSql();

        public Task <List <Blog>> GetAllBlogsAsyunc ()
        {
            return _BloggeriumContextSql.Blogs.ToListAsync();
        }

        // TODO: Make special result class with result status and the containing object.
        public Task <EntityEntry <Blog>> AddBlog (Blog blog)
        {
            Task <EntityEntry <Blog>> addAsync = _BloggeriumContextSql.AddAsync(blog);
            try
            {
                _BloggeriumContextSql.SaveChangesAsync();
            }
            catch (Exception) { }
            return addAsync;
        }
    }
}