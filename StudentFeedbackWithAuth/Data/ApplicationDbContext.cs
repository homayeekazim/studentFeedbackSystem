using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentFeedbackWithAuth.Models;

namespace StudentFeedbackWithAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FeedbackQuestion> Question { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        //public DbSet<Libraray> Title { get; set; }
    }
}
