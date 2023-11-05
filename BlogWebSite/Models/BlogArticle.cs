using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogWebSite.Models
{
    public class BlogArticle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(2500)]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
