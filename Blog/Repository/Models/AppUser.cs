using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Repository.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser(string userName) : base(userName)
        {
        }
        public AppUser()
        {
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayName("Image")]
        public string ImageUrl { get; set; }
        [NotMapped]
        public bool IsImage { get; set; }

        public ICollection<Post> Posts { get; set; }

    }
}
