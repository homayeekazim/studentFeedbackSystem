using System;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackWithAuth.Models
{
    public class FeedbackQuestion
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string ResponseType { get; set; }
        public string Color { get; set; }
    }
}
