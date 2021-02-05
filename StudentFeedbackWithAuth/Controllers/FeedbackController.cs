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
    public class FeedbackController : Controller
    {
        private readonly ApplicationDbContext _context;
        QuestionTypeService qt = new QuestionTypeService();

        public FeedbackController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Feedback
        public async Task<IActionResult> Index()
        {
            var questions = await _context.Question.ToListAsync();

            foreach (FeedbackQuestion question in questions)
            {
                var color = qt.SelectQuestionType(question);
                question.Color = color;
            }
            return View(questions);
        }

        // GET: Feedback/FeedbackForm
        public async Task<IActionResult> FeedbackForm()
        {
            var questions = await _context.Question.ToListAsync();
            MinQuestionsForFeedbackService minQuestions = new MinQuestionsForFeedbackService();
            var minQuestionsAvailable = minQuestions.atLeast2Question(questions.Count);

            if (!minQuestionsAvailable)
            {
                return NotFound();
            }
            return View(questions);
        }

        // GET: Feedback/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackQuestions = await _context.Question
                .FirstOrDefaultAsync(m => m.Id == id);
            if (feedbackQuestions == null)
            {
                return NotFound();
            }

            return View(feedbackQuestions);
        }

        // GET: Feedback/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Feedback/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Question,ResponseType")] FeedbackQuestion feedbackQuestions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedbackQuestions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feedbackQuestions);
        }

        // GET: Feedback/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackQuestions = await _context.Question.FindAsync(id);
            if (feedbackQuestions == null)
            {
                return NotFound();
            }
            return View(feedbackQuestions);
        }

        // POST: Feedback/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Question,ResponseType")] FeedbackQuestion feedbackQuestions)
        {
            if (id != feedbackQuestions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feedbackQuestions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackQuestionsExists(feedbackQuestions.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(feedbackQuestions);
        }

        // GET: Feedback/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackQuestions = await _context.Question
                .FirstOrDefaultAsync(m => m.Id == id);
            if (feedbackQuestions == null)
            {
                return NotFound();
            }

            return View(feedbackQuestions);
        }

        // POST: Feedback/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var feedbackQuestions = await _context.Question.FindAsync(id);
            _context.Question.Remove(feedbackQuestions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeedbackQuestionsExists(int id)
        {
            return _context.Question.Any(e => e.Id == id);
        }
    }
}
