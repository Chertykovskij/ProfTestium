using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProfTestium.Models;
using ProfTestium.Models.Contexts;
using ProfTestium.Models.ViewModels;
using System.Collections.Generic;

namespace ProfTestium.Controllers
{
    public class TestsController : Controller
    {
        private readonly ProfTestiumContext _context;

        public TestsController(ProfTestiumContext context) { _context = context; }

        public ActionResult Index()
        {
            List<Test> tests = _context.Tests.Include(t => t.Course).ToList();
                
            return View(tests);
        }

        public ActionResult Details(int id)
        {
            Test test = _context.Tests.FirstOrDefault(t => t.Id == id);

            if (test == null)
            {
                return NotFound();
            }

            List <Quest> questions = _context.Quests.Where(q => q.Test_id == test.Id).ToList();
    
            foreach (Quest question in questions)
            {
                question.Answers = _context.Answers.Where(a => a.Query_id == question.Id).ToList();
            }

            return View(new TestViewModel { Test = test, Questions = questions });
        }


        public async Task<IActionResult> Create()
        {
            ViewBag.Courses = await GetCourses();

            

            return View(new TestViewModelToCreate());
        }



        [HttpPost]
        public IActionResult Create(TestViewModelToCreate testVM)
        {
            var test = new Test();
            test.Title = testVM.Title;
            test.Description = testVM.Description;
            test.Course = testVM.Course;
            //test.Questions = testVM.; 

            _context.Tests.Add(test);

            foreach (var quest in test.Questions)
            {
                quest.Answers = quest.Answers;

                _context.Quests.Add(quest);

                foreach (var answer in quest.Answers)
                {
                    _context.Answers.Add(answer);
                }
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


        public ActionResult Edit(int id)
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        [ValidateAntiForgeryToken]
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



        private async Task<List<SelectListItem>> GetCourses()
        {
            var items = await _context.Courses.ToListAsync();


            var listItems = items.Select(item => new SelectListItem()
            {
                Value = item.Id.ToString(),
                Text = item.Title.ToString()
            }).ToList();


            return listItems;
        }
    }
}
