using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public List<Post> Post{ get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int idBlog { get; set; }

        public Blog blog { get; set; }
    }
}
