using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineShopSystem.Model;
using OnlineShopSystem.Model.Product;

namespace OnlineShopSystem.UI.Controllers
{
    public class MngBaseProductController : Controller
    {
        private SysContext db = new SysContext();

        // GET: MngBaseProduct
        public ActionResult Index()
        {
            return View(db.BaseProducts.ToList());
        }

        // GET: MngBaseProduct/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseProduct baseProduct = db.BaseProducts.Find(id);
            if (baseProduct == null)
            {
                return HttpNotFound();
            }
            return View(baseProduct);
        }

        // GET: MngBaseProduct/Create
        public ActionResult Create()
        {
            ViewBag.Categories = (from s in db.BaseCategories
                                  select new SelectListItem
                                  {
                                      Text = s.CateName,
                                      Value = s.CateID.ToString()
                                  }).ToList();

            return View();
        }

        // POST: MngBaseProduct/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,CateID,Name,SubTitle,Detail,ThumbImgUrl,Price,Stock,IsUsed,CreateTime,UpdateTime")] BaseProduct baseProduct)
        {
            if (ModelState.IsValid)
            {
                db.BaseProducts.Add(baseProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(baseProduct);
        }

        // GET: MngBaseProduct/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseProduct baseProduct = db.BaseProducts.Find(id);
            if (baseProduct == null)
            {
                return HttpNotFound();
            }
            return View(baseProduct);
        }

        // POST: MngBaseProduct/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,CateID,Name,SubTitle,Detail,ThumbImgUrl,Price,Stock,IsUsed,CreateTime,UpdateTime")] BaseProduct baseProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baseProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(baseProduct);
        }

        // GET: MngBaseProduct/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseProduct baseProduct = db.BaseProducts.Find(id);
            if (baseProduct == null)
            {
                return HttpNotFound();
            }
            return View(baseProduct);
        }

        // POST: MngBaseProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BaseProduct baseProduct = db.BaseProducts.Find(id);
            db.BaseProducts.Remove(baseProduct);
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
