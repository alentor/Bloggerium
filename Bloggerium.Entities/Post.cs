using System;
using System.ComponentModel.DataAnnotations;

namespace Bloggerium.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        [Timestamp]
        public byte[] Timestaimp { get; set; }
    }
}