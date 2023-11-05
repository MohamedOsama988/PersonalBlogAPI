namespace BlogWebSite.Services
{
    public interface IBlogArticalsOperations
    {
        IEnumerable<BlogArticle> GetAllArticles();
        BlogArticle GetArticleById(int id);
        BlogArticle CreateArtical(BlogArticle newArticle);
        BlogArticle UpdateArtical(int id, BlogArticle newArticle);

        Task DeleteArtical(int id);
    }
}
