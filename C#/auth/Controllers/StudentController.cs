using auth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace auth.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext studentdb;

        public StudentController(StudentDbContext studentdb)
        {
            this.studentdb = studentdb;
        }

        public async Task<IActionResult> fatch()
        {
            var stddata =await studentdb.users.ToListAsync();
            return View(stddata);
        }



        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Student std)
        {
            if (ModelState.IsValid)
            {
              await  studentdb.users.AddAsync(std);
              await  studentdb.SaveChangesAsync();
                return RedirectToAction("fatch", "student");
            }
            return View(std);
        }


        public async Task<IActionResult> details(int? id)
        {
if(id == null)
            {
               return NotFound();
            }
            var data=await studentdb.users.FirstOrDefaultAsync(x => x.id == id);
            return View(data);
        }




                public async Task<IActionResult> Edit(int? id)
        {
if(id == null)
            {
               return NotFound();
            }
            var data=await studentdb.users.FindAsync(id);
            return View(data);
        }


    [HttpPost]
        public async Task<IActionResult> Edit(int? id ,Student std)
        {
if(id!= std.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                studentdb.users.Update(std);
              await  studentdb.SaveChangesAsync();
                return RedirectToAction("fatch", "student");
            }
            return View(std);
        }
        

                        public async Task<IActionResult> delete(int? id)
        {
              var data=await studentdb.users.FindAsync(id);
if(data!= null)
            {
               studentdb.users.Remove(data);
            }
            await studentdb.SaveChangesAsync();
         
            return RedirectToAction("fatch","student");
        }


    }
}
