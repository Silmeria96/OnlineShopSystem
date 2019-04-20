using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineShopSystem.Model;
using OnlineShopSystem.Model.Category;

namespace OnlineShopSystem.UI.Controllers
{
    public class MngBaseCategoryController : Controller
    {
        private SysContext db = new SysContext();

        // GET: MngBaseCategory
        public ActionResult Index()
        {
            return View(db.BaseCategories.ToList());
        }

        // GET: MngBaseCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseCategory baseCategory = db.BaseCategories.Find(id);
            if (baseCategory == null)
            {
                return HttpNotFound();
            }
            return View(baseCategory);
        }

        // GET: MngBaseCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MngBaseCategory/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CateID,PID,OrderID,CateName,IsUsed,CreateTime,UpdateTime")] BaseCategory baseCategory)
        {
            if (ModelState.IsValid)
            {
                db.BaseCategories.Add(baseCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(baseCategory);
        }

        // GET: MngBaseCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseCategory baseCategory = db.BaseCategories.Find(id);
            if (baseCategory == null)
            {
                return HttpNotFound();
            }
            return View(baseCategory);
        }

        // POST: MngBaseCategory/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CateID,PID,OrderID,CateName,IsUsed,CreateTime,UpdateTime")] BaseCategory baseCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baseCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(baseCategory);
        }

        // GET: MngBaseCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseCategory baseCategory = db.BaseCategories.Find(id);
            if (baseCategory == null)
            {
                return HttpNotFound();
            }
            return View(baseCategory);
        }

        // POST: MngBaseCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BaseCategory baseCategory = db.BaseCategories.Find(id);
            db.BaseCategories.Remove(baseCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
