using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }

        public ICollection<PostCategory> Posts { get; set; }

    }
}
