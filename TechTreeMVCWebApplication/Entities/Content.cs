﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechTreeMVCWebApplication.Entities
{
    public class Content
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        public string HTMLContent { get; set; }
        public string VideoLink { get; set; }
        public CategoryItem CategoryItem { get; set; }
    }
}
