using System;
using StudentFeedbackWithAuth.Models;

namespace StudentFeedbackWithAuth.Data
{
    public class ClassRatingService
    {
        public string SelectClassRatingColor(Course course)
        {
            if (course.AvgRating >= 2.5)
            {
                return "green";
            }

            return "red";

        }
    }
}
