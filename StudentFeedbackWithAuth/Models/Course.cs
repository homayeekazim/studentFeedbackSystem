using System;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackWithAuth.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public double AvgRating { get; set; }
        public string ratingGrade { get; set; }
    }
}