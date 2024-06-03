using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuadTheoryLimited_Task.Data;
using QuadTheoryLimited_Task.Models;

namespace QuadTheoryLimited_Task.Controllers
{
    public class PortalController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PortalController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Student> studentList = _db.Student.Include(s => s.Class).ToList();
            return View(studentList);
        }


        // GET: Portal/Create
        public IActionResult Create()
        {
            ViewBag.Classes = _db.Class.ToList();
            return View();
        }

        // POST: Portal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = Guid.NewGuid();
                student.CreatedDate = DateTime.Now;
                student.ModificationDate = DateTime.Now;
                _db.Student.Add(student);
                _db.SaveChanges();
                TempData["success"] = "Information added successfully";
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Classes = _db.Class.ToList();
            return View(student);
        }

        public IActionResult Edit(Guid? id) {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Classes = _db.Class.ToList();
            Student studentDb = _db.Student.Find(id);
            if(studentDb == null)
            {
                return NotFound();
            }
            return View(studentDb);
        }

        // POST: Portal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                /*student.Id = Guid.NewGuid();
                student.CreatedDate = DateTime.Now;*/
                student.ModificationDate = DateTime.Now;
                _db.Student.Update(student);
                _db.SaveChanges();

                TempData["success"] = "Information edited successfully";
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Classes = _db.Class.ToList();
            return View(student);
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Classes = _db.Class.ToList();
            Student studentDb = _db.Student.Find(id);
            if (studentDb == null)
            {
                return NotFound();
            }
            return View(studentDb);
        }

        // POST: Portal/Create
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteInfo(Guid? id)
        {
            Student student = _db.Student.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            _db.Student.Remove(student);
            
                _db.SaveChanges();
            TempData["success"] = "Information deleted successfully";
            return RedirectToAction(nameof(Index));
           
        }

        // GET: Portal/Details/{id}
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _db.Student
                .Include(s => s.Class)
                .FirstOrDefault(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}
