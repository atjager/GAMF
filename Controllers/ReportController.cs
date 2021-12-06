using GAMF.Data;
using GAMF.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using GAMF.ViewModels;

namespace GAMF.Controllers
{
    public class ReportController : Controller

    {
        private readonly GAMFDbContext _context;
        public ReportController(GAMFDbContext context)
        {
            //_context = context;
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult EnrollmentDateReport()

        {

            var result = from student in _context.Students
                         group student by student.EnrollmentDate into dateGroup
                         select new EnrollmentDateVM

                         {
                             EnrollmentDate = dateGroup.Key,
                             StudentCount = dateGroup.Count()
                         };
            return View(result.ToList());

        }

        public IActionResult CreditReport()
        {
            var result = from student in _context.Students
                         join enrollment in _context.Enrollments on student.Id equals enrollment.StudentId
                         join course in _context.Courses on enrollment.CourseId equals course.CourseId
                         group course.Credits by student.FirstMidName + " " + student.LastName into dataGroup
                         select new CreditReportVM
                         {
                             Credits = dataGroup.Sum(),
                             Student = dataGroup.Key
                         };

            return View(result.ToList());
        }

    }
}
