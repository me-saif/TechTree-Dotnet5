using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTreeMVCWebApplication.Entities
{
    public class Content
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "HTML Content")]
        public string HTMLContent { get; set; }

        [Display(Name = "Video Link")]
        public string VideoLink { get; set; }

        public CategoryItem CategoryItem { get; set; }

        [NotMapped]
        public int CatItemId { get; set; }

        [NotMapped]
        public int CategoryId { get; set; }
    }
}