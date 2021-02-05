using System;
using System.Collections.Generic;
using StudentFeedbackWithAuth.Models;

namespace StudentFeedbackWithAuth.Data
{
    public class QuestionTypeService
    {
        public string SelectQuestionType(FeedbackQuestion questions)
        {
            if (questions.ResponseType == "text")
            {
                return "red";
            }

            return "green";
            
        }
    }
}
