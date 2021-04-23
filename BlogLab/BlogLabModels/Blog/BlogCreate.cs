using System;
using System.ComponentModel.DataAnnotations;

namespace BlogLabModels.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is requiered")]
        [MinLength(10, ErrorMessage = "Must be at least 10-50 characters")]
        [MaxLength(50, ErrorMessage = "Must be at least 10-50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is requiered")]
        [MinLength(300, ErrorMessage = "Must be at least 300-3000 characters")]
        [MaxLength(3000, ErrorMessage = "Must be at least 300-3000 characters")]
        public string Content { get; set; }

        public int? PhotoId { get; set; }

    }
}
