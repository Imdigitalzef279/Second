using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Second.Models;

namespace Second.Controllers
{
    public class LopController : Controller
    {
        // GET: LopController
        public ActionResult Index()
        {
            var listLop = new ProjectNewContext().Lops.ToList();
            return View(listLop);
        }

        // GET: LopController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LopController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Lop model)
        {
            try
            {
                var context = new ProjectNewContext();
                context.Lops.Add(model);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LopController/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new ProjectNewContext();
            var editing = context.Lops.Find(id);
            return View(editing);
        }

        // POST: LopController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Lop model)
        {
            try
            {
                var context = new ProjectNewContext();
                var oldItem = context.Lops.Find(model.Id);
                oldItem.SoGhe =model.SoGhe;
                oldItem.SoBan = model.SoBan;
                oldItem.Id = model.Id;
                oldItem.LoaiLop = model.LoaiLop;
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LopController/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new ProjectNewContext();
            var deleting = context.Lops.Find(id);
            return View(deleting);
        }

        // POST: LopController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Lop model)
        {
            try
            {
                var context = new ProjectNewContext();
                var deleting = context.Lops.Find(id);
                context.Lops.Remove(deleting);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
