using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class PostCategory
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
