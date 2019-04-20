using Newtonsoft.Json.Linq;
using OnlineShopSystem.BLL.User;
using OnlineShopSystem.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    // 后台管理 - 客户管理模块

    public class MngCustomerController : Controller
    {
        // GET: MngCustomer
        public ActionResult Index()
        {
            return View();
        }



        // 获取全部客户
        public JObject GetAll()
        {
            JObject data = CustomerManager.GetAllCustomers();

            return data;
        }



        // GET: MngCustomer1/Create
        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Account,Password,DisplayName,Token,CreateTime,UpdateTime,Age,Birthday,Address")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                CustomerManager.AddCustomer(customer);
                return RedirectToAction("Index");
            }

            return View(customer);
        }



        public ActionResult Edit(int? id)
        {
            // 如果ID不存在，返回错误信息
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Customer customer = CustomerManager.FindById(id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Account,Password,DisplayName,Token,CreateTime,UpdateTime,Age,Birthday,Address")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        
    }
}