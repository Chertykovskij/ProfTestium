using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProfTestium.Models;
using ProfTestium.Models.Contexts;

namespace ProfTestium.Controllers
{
    public class CourseController : Controller
    {
        private readonly ProfTestiumContext _context;

        public CourseController(ProfTestiumContext context) { _context = context; }

        public ActionResult Index()
        {
            List<Course> courses = _context.Courses.ToList();

            return View(courses);
        }

        public ActionResult Details(int id)
        {
            Course course = _context.Courses.Include(c => c.Organization).FirstOrDefault(t => t.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        public async Task<ActionResult> Create()
        {
            ViewBag.Organizations = await GetOrg();

            return View(new Course());
        }

        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private async Task<List<SelectListItem>> GetOrg()
        {
            var items = await _context.Organizations.ToListAsync();


            var listItems = items.Select(item => new SelectListItem()
            {
                Value = item.Id.ToString(),
                Text = item.Name.ToString()
            }).ToList();


            return listItems;
        }
    }
}
