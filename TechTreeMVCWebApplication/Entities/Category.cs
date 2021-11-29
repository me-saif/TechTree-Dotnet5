using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTreeMVCWebApplication.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public string ThumbnailImagePath { get; set; }

        [ForeignKey("CategoryId")]
        public ICollection<CategoryItem> CategoryItems { get; set; }

        [ForeignKey("CategoryId")]
        public ICollection<UserCategory> UserCategory { get; set; }
    }
}
