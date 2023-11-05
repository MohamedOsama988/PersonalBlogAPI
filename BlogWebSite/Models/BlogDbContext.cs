
namespace BlogWebSite.Models
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }
        
        public DbSet<BlogArticle> BlogArticles { get; set; }
    }
}
