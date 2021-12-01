﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTreeMVCWebApplication.Entities
{
    public class CategoryItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int MediaTypeId { get; set; }

        [NotMapped]
        public virtual ICollection<SelectListItem> MediaTypes { get; set; }
        public DateTime DateTimeReleased { get; set; }
        [NotMapped]
        public int ContentId { get; set; }

    }
}
