using System;
namespace StudentFeedbackWithAuth.Data
{
    public class MinQuestionsForFeedbackService
    {
        public bool atLeast2Question(int questions)
        {
            if (questions > 1)
            {
                return true;
            }

            return false;

        }
    }
}
