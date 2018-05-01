using System.Collections;
using System.Collections.Generic;

namespace CBA.AP.Blog.Domain.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}