using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Second.Models;

namespace Second.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVienController
        public ActionResult Index()
        {
            var listSinhVien = new ProjectNewContext().SinhViens.ToList();
            return View(listSinhVien);
        }

        // GET: SinhVienController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SinhVienController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SinhVienController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SinhVien model)
        {
            try
            {
                var context = new ProjectNewContext();
                context.SinhViens.Add(model);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SinhVienController/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new ProjectNewContext();
            var editing = context.SinhViens.Find(id);
            return View(editing);
            
        }

        // POST: SinhVienController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SinhVien model)
        {
            try
            {
                var context = new ProjectNewContext();
                var oldItem = context.SinhViens.Find(model.Id);
                oldItem.IdChucVu = model.IdChucVu;
                oldItem.HoVaTen = model.HoVaTen;
                oldItem.Id = model.Id;
                oldItem.GioiTinh = model.GioiTinh;
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SinhVienController/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new ProjectNewContext();
            var deleting = context.SinhViens.Find(id);
            return View(deleting);
        }

        // POST: SinhVienController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SinhVien model)
        {
            try
            {
                var context = new ProjectNewContext();
                var deleting = context.SinhViens.Find(id);
                context.SinhViens.Remove(deleting);
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
