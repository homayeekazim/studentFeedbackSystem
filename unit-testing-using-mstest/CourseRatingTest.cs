using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentFeedbackWithAuth.Data;
using StudentFeedbackWithAuth.Models;

namespace unit_testing_using_mstest
{
    [TestClass]
    public class CourseRatingTest
    {
        [TestMethod]
        public void greenCourseRatingColor()
        {
            ClassRatingService rating = new ClassRatingService();

            Course sampleCouse = new Course();
            sampleCouse.AvgRating = 5;

            var grade = rating.SelectClassRatingColor(sampleCouse);

            Assert.AreEqual("green", grade);
        }

        [TestMethod]
        public void redCourseRatingColor()
        {
            ClassRatingService rating = new ClassRatingService();

            Course sampleCouse = new Course();
            sampleCouse.AvgRating = 2;

            var grade = rating.SelectClassRatingColor(sampleCouse);

            Assert.AreEqual("red", grade);
        }

        //[TestMethod]
        //public void falseCourseRatingColor()
        //{
        //    ClassRatingService rating = new ClassRatingService();

        //    Course sampleCouse = new Course();
        //    sampleCouse.AvgRating = 5;

        //    var grade = rating.SelectClassRatingColor(sampleCouse);

        //    Assert.AreEqual("red", grade);
        //}

        [TestMethod]
        public void atleast2questions()
        {
            MinQuestionsForFeedbackService minRequired = new MinQuestionsForFeedbackService();


            var isOkay = minRequired.atLeast2Question(2);

            Assert.IsTrue(isOkay, "Minimum number of required questions are available!");
        }

        [TestMethod]
        public void atleast2questionsFail()
        {
            MinQuestionsForFeedbackService minRequired = new MinQuestionsForFeedbackService();


            var isOkay = minRequired.atLeast2Question(1);

            Assert.IsFalse(isOkay, "Minimum number of required questions are not available!");
        }
    }
}
