using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bloggerium.Entities
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}