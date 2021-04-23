using System;
using System.ComponentModel.DataAnnotations;

namespace BlogLabModels.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }

        public int? ParentBlogCommentId { get; set; }

        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is requiered")]
        [MinLength(10, ErrorMessage = "Must be at least 10-300 characters")]
        [MaxLength(300, ErrorMessage = "Must be at least 10-300 characters")]
        public string Content { get; set; }
    }
}
