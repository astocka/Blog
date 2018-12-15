using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Blog.Models
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

        public string ImageUrl { get; set; }
        public bool IsImage { get; set; }

    }
}
