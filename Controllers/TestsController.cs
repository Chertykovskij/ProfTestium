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
            _context.Database.ExecuteSqlRaw("INSERT INTO [Tests] VALUES ({0},{1},{2},{3})", 
                testVM.Title, testVM.Description, testVM.Course_id, testVM.Course_id);

            var test = _context.Tests.OrderByDescending(t => t.Id).FirstOrDefault();

            foreach (var questVM in testVM.Questions)
            {
                if (string.IsNullOrEmpty(questVM.Title)) { continue; }

                _context.Database.ExecuteSqlRaw("INSERT INTO Quests VALUES ({0},{1},{2})",
                    questVM.Title, test.Id, test.Id);

                var quest = _context.Quests.OrderByDescending(t => t.Id).FirstOrDefault();

                foreach (var answerVM in questVM.Answers)
                {
                    if (answerVM.Title == null) { continue; }

                    _context.Database.ExecuteSqlRaw("INSERT INTO [Answers] VALUES ({0},{1},{2},{3})",
                        answerVM.Title, answerVM.Correct ? 1 : 0, quest.Id, quest.Id);
                }

            }
            return RedirectToAction("Index", "Tests");
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
