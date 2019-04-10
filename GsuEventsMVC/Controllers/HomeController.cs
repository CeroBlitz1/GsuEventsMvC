using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GsuEventsMVC.Models;

namespace GsuEventsMVC.Controllers
{
    public class HomeController : Controller
    {
        public GsuDBEntities g = new GsuDBEntities();

        public ActionResult Index()
        {
            return View();
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,UserPassword,UserName,UserEmail,UserPhoneNumber,isActive,UserTypeID,CreatedDate,ModifiedDate,isDelete")] UserModel userTable)
        {

            if (ModelState.IsValid)
            {

                var usr = g.UserTables.Where(s => s.UserName == userTable.UserName).FirstOrDefault();

                try
                {
                    var Userstblobj = new UserModel();

                    Userstblobj.UserPassword = userTable.UserPassword;
                    Userstblobj.UserName = userTable.UserName;
                    userTable.UserEmail = userTable.UserEmail;
                    Userstblobj.UserPhoneNumber = userTable.UserPhoneNumber;
                    Userstblobj.isActive = "Y";
                    Userstblobj.UserTypeID = 1;
                    Userstblobj.isDelete = 0;
                    Userstblobj.CreatedDate = DateTime.Now;
                    Userstblobj.ModifiedDate = DateTime.Now;



                    g.UserTables.Add(Userstblobj);
                    g.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {

                    string d = ex.Message;

                }


            }
            return View(userTable);
        }
    }
}