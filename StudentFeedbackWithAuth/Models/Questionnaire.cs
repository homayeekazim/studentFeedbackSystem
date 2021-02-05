using System;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackWithAuth.Models
{
    public class Questionnaire
    {
        [Key]
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int CourseId { get; set; }
    }
}
