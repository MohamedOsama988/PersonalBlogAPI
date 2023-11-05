
using Microsoft.EntityFrameworkCore;

namespace BlogWebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        IBlogArticalsOperations _blogArticalsOperations;
        public BlogController(IBlogArticalsOperations blogArticalsOperations)
        {
            _blogArticalsOperations = blogArticalsOperations;
        }

        [HttpGet]
        [Route("getall")]
        public ActionResult<IEnumerable<BlogArticle>> GetAll()
        {
            var articales = _blogArticalsOperations.GetAllArticles();
            return Ok(articales);
        }

        [HttpGet]
        [Route("get/{id}")]
        public ActionResult<BlogArticle> Get(int id)
        {
            var artical = _blogArticalsOperations.GetArticleById(id);
            return Ok(artical);
        }

        [HttpPost]
        [Route("create")]
        public ActionResult<BlogArticle> Create([FromBody] BlogArticle newArticle)
        {
            if (newArticle == null)
            {
                   return BadRequest();
            }
            var article = _blogArticalsOperations.CreateArtical(newArticle);
            return Ok(article);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _blogArticalsOperations.DeleteArtical(id);
            return Ok("Deleted");
        }

        [HttpPut]
        [Route("update/{id}")]
        public IActionResult Put(int id, [FromBody] BlogArticle newArticle)
        {
            var article = _blogArticalsOperations.UpdateArtical(id, newArticle);
            return Ok(article);
        }

    }
}
