using JobWebsite.Data;
using JobWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JobWebsite.Controllers
{
    public class JobApplicationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobApplicationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("ApplicationForm");
        }

        [HttpPost]
        public IActionResult Submit(JobApplication model)
        {
            if (ModelState.IsValid)
            {
                _context.JobApplications.Add(model);
                _context.SaveChanges();
                return RedirectToAction("ThankYou");
            }

            return View("ApplicationForm", model);
        }

        public IActionResult SavedEntries()
        {
            var savedEntries = _context.JobApplications.ToList();
            return View(savedEntries);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var entryToDelete = _context.JobApplications.Find(id);

            if (entryToDelete != null)
            {
                _context.JobApplications.Remove(entryToDelete);
                _context.SaveChanges();
            }

            // After deletion, redirect back to the "SavedEntries" page
            return RedirectToAction("SavedEntries");
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
