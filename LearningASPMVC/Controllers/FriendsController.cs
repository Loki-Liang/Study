using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningASPMVC.Models;

namespace LearningASPMVC.Controllers
{
    public class FriendsController : Controller
    {
        // GET: Friends
        public ActionResult Index()
        {
            return View();
        }

        // GET: Friends/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Friends/Create
        public ActionResult Create()
        {
            Person person = new Person();
            return View(person);
        }

        // POST: Friends/Create
        [HttpPost]
        public ActionResult Create(Person friendToCreate)
        {
            if (ModelState.IsValid)
            {
                //模型验证成功，进行数据持久层工作
                return Redirect("/");
            }
            //如果模型验证失败，重新填写，并提示。
            return View(friendToCreate);  

            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Friends/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Friends/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Friends/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Friends/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
