using ConsoleApp.Model;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //addBlog();

            UpdateBlog();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static void addBlog() {
            using (var blog = new TestDBContext())
            {
                Blog b = new Blog() { URL = "Testing"};
                blog.Blogs.Add(b);
                blog.SaveChanges();
            }
        }

        static void UpdateBlog()
        {
            using (var blog = new TestDBContext())
            {
                Blog b = new Blog() { URL = " New URLTesting" };
                blog.Blogs.Update(b);
                blog.SaveChanges();
            }
        }
    }
}
