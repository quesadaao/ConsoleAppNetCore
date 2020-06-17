using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public class TestDBContext : DbContext
    {
        public TestDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;AttachDbFilename=|DataDirectory|\aspnet_WebApplication.mdf;Initial Catalog=aspnet_WebApplication;Integrated Security=True");
            //C:\GitQuesadaao\ConsoleApp\AppData
            //Server=.\SQLExpress;AttachDbFilename=C:\MyFolder\MyDataFile.mdf;Database=dbname;Trusted_Connection=Yes;
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;AttachDbFilename=C:\\GitQuesadaao\\ConsoleApp\\AppDataMyDataFile.mdf;Database=dbname;Trusted_Connection=Yes;");
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;AttachDbFilename=|DataDirectory|aspnet_WebApplication.mdf;Database=dbname;Trusted_Connection=Yes;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Blog> Blogs { get; set; }
    }
}
