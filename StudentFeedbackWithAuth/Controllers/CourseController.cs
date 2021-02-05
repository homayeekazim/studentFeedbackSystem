using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentFeedbackWithAuth.Data;
using StudentFeedbackWithAuth.Models;

namespace StudentFeedbackWithAuth.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Course
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();
            ClassRatingService rating = new ClassRatingService();

            foreach (Course course in courses)
            {
                var color = rating.SelectClassRatingColor(course);
                course.ratingGrade = color;
            }
            return View(courses);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Course/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,InstructorId")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Course/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Course/FeedbackForm/1
        public async Task<IActionResult> FeedbackForm(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var course = await _context.Courses
            //    .FirstOrDefaultAsync(m => m.Id == id);

            //var questions = await _context.Question
            //    .ToListAsync();

            //var question = from question in _context.Question
            //                join questionnaire in _context.Questionnaires
            //                on question.Id equals questionnaire.QuestionId
            //                where questionnaire.CourseId == id
            //                select new { question };

            //var question = await _context.Question.Join(_context.Questionnaires, qu => qu.Id,
            //    q => q.QuestionId, (q, qu) => new { q, qu })
            //    .Where(x => x.qu.CourseId == id)
            //    .ToListAsync();

            //var questionnaires = await _context.Questionnaires
            //    .Where(x => x.CourseId == id)
            //    .ToListAsync();
            var questions = await _context.Question
                .Where(x => x.Color == id)
                .ToListAsync();

            //List<StudentFeedbackWithAuth.Models.FeedbackQuestion> newList = new List<StudentFeedbackWithAuth.Models.FeedbackQuestion>();
            //foreach (var item in questionnaires)
            //{
            //    StudentFeedbackWithAuth.Models.FeedbackQuestion listItem = new StudentFeedbackWithAuth.Models.FeedbackQuestion();
            //    listItem.Id = item.QuestionId;
            //    var questions = await _context.Question
            //        .Where(x => x.Id == item.QuestionId)
            //        .ToListAsync();
            //    //listItem.Question = questions.Question;
            //    //listItem.ResponseType = questions.ResponseType;
            //    //add your remaining fields
            //    newList.Add(listItem);
            //}

            //var query = from question in _context.Set<FeedbackQuestion>()
            //            join questionnaire in _context.Set<Questionnaire>()
            //                on new { Id = (int?)photo.PersonPhotoId, Caption = photo.Caption }
            //                equals new { Id = person.PhotoId, Caption = "SN" }
            //            select new { person, photo };

            if (questions == null)
            {
                return NotFound();
            }

            return View(questions);
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}