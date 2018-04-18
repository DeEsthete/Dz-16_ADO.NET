namespace Dz_16
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NewsContext : DbContext
    {
        public NewsContext()
            : base("name=NewsContext")
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}