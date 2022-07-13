using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementWithIdentity.Data;

namespace UserManagementWithIdentity.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LabtopController : Controller
    {
        ApplicationDbContext db;
        public LabtopController(ApplicationDbContext _db)
        {
            db = _db;
        }
        // GET: LabtopController
        public ActionResult Index()
        {
            return View(db.Laptops.ToList());
        }

        // GET: LabtopController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LabtopController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LabtopController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // GET: LabtopController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LabtopController1/Edit/5
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

        // GET: LabtopController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LabtopController1/Delete/5
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
    }
}
