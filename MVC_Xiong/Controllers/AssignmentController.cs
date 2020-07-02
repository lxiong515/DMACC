using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Xiong.Data;
using MVC_Xiong.Models;

namespace MVC_Xiong.Controllers
{
    public class AssignmentController : Controller
    {
        private List<Student> _students = new List<Student>() {                
            new Student
                {
                    ID = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    Grade = "A"
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Jimmy",
                    LastName = "Fallon",
                    Grade = "A"
                },
                new Student
                {
                    ID = 3,
                    FirstName = "Conan",
                    LastName = "O'Brien",
                    Grade = "A"
                } };

        public AssignmentController(StudentContext context)
        {
            _context = context;
        }
        private readonly StudentContext _context; 

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.RU = "";
            Student stu = new Student();
            return View(stu);

        }

        [HttpPost]
        public IActionResult Index(Student model)
        {
            //ViewBag.RU = model.RouteUser(); //method has been commented out in model - need to fix
            //If the access level is less than 2 show only "You do not 
            //have a sufficient access level to view this data." 
            if (model.Number <= 2)
                return View("~/Views/Assignment/two.cshtml");
            else if (model.Number > 2 && model.Number < 8)
                return View("~/Views/Assignment/eight.cshtml",_students);
            else if (model.Number >= 8)
                return View("~/Views/Assignment/admin.cshtml",_students);
            return View(model);
        }
        //If the access level is less than 2 show only "You do not 
        //have a sufficient access level to view this data." 

        
       
        /*
        // GET: Contacts1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Contacts1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Phone,Address,Note")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Contacts1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Phone,Address,Note")] Student student)
        {
            if (id != Student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            return View(student);
        }

        // GET: Contacts1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Contacts1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
        */

    }
}
