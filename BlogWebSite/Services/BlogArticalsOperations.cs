namespace BlogWebSite.Services
{
    public class BlogArticalsOperations : IBlogArticalsOperations
    {
        BlogDbContext _context;
        public BlogArticalsOperations(BlogDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BlogArticle> GetAllArticles()
        {
            return _context.BlogArticles.ToList();
        }

        public BlogArticle GetArticleById(int id)
        {
            BlogArticle artical = _context.BlogArticles.Find(id);
            if(artical == null)
            {
                throw new Exception("Artical not found");
            }
            else
            {
                return artical;
            }
        }

        public BlogArticle CreateArtical(BlogArticle newArticle)
        {
            BlogArticle article = new BlogArticle()
            {
                Title = newArticle.Title,
                Content = newArticle.Content,
                CreatedDate = DateTime.Now
            };

            _context.BlogArticles.Add(article);
            _context.SaveChanges();

            return article;
        }

        public BlogArticle UpdateArtical(int id, BlogArticle newArticle)
        {
            BlogArticle artical = _context.BlogArticles.Find(id);
            if(artical == null)
            {
                throw new Exception("Artical not found");
            }
            else
            {
                artical.Title = newArticle.Title;
                artical.Content = newArticle.Content;
                artical.CreatedDate = DateTime.Now;
                _context.BlogArticles.Update(artical);
                _context.SaveChanges();
                return artical;
            }
        }

        public Task DeleteArtical(int id)
        {
            var artical = _context.BlogArticles.Find(id);
            _context.BlogArticles.Remove(artical);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
