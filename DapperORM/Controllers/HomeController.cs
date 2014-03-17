using DapperORM.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperORM.Controllers
{
    public class HomeController : Controller
    {
        private IUserRepository _repository = new UserRepository();
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        // GET: /User/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: /User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,FirstName,LastName,Email")] User user)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: /User/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repository.GetUserInformatiom(id));
        }

        // POST: /User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,FirstName,LastName,Email")] User user, int id)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(user);
            }
            return View(user);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}