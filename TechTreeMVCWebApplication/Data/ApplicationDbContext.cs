using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TechTreeMVCWebApplication.Entities;

namespace TechTreeMVCWebApplication.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [StringLength(250)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(250)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(50)]
        public string PostCode { get; set; }

        [ForeignKey("UserId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryItem> CategoryItems { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<UserCategory> UserCategories { get; set; }
    }
}