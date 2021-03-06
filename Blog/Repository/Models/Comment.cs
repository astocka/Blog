﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nickname { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("Posted on")]
        public DateTime PostedOn { get; set; }

        [DisplayName("Post")]
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        
    }
}
