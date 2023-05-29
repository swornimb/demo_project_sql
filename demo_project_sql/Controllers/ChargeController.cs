using demo_project_sql.Data;
using demo_project_sql.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_project_sql.Controllers
{
    public class ChargeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ChargeController(ApplicationDbContext db)
        {
            _db = db; 
            
        }
        public IActionResult Index()
        {
            IEnumerable<Models.Charge> objChargesList = _db.Charges;
            return View(objChargesList);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var onecharge = _db.Charges.Find(id);
            return View(onecharge);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Charge obj)
        {
            _db.Charges.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Charge obj)
        {
            _db.Charges.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            var onecharge = _db.Charges.Find(id);
            return View(onecharge);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Charges.Find(id);
            _db.Charges.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
