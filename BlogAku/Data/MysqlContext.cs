using BlogAku.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogAku.Data
{
    public class MysqlContext:DbContext
    {
        public MysqlContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}
