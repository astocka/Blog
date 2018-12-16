using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Repository.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Published { get; set; }
        public bool Modified { get; set; }

        [Required]
        [DisplayName("Username")]
        public string AppUserId { get; set; }
        [ForeignKey("AppUserId")]
        public AppUser AppUser { get; set; }

        public ICollection<PostCategory> Categories { get; set; }

        public ICollection<PostTag> Tags { get; set; }

        [DisplayName("Comments")]
        public int CommentId { get; set; }
        public ICollection<Comment> Comments { get; set; }
        
    }
}
