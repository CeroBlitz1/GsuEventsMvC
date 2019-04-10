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
    public class RegistrationController : Controller
    {
        public GsuDBEntities g = new GsuDBEntities();

        public ActionResult Registration()
        {
            return View();
        }

        // User Login Controller
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "UserName,UserID,isDelete")] UserModel Model)
        {




            try
            {
                var usr = g.UserTables.Where(s => s.UserName == Model.UserName).FirstOrDefault();
                if (usr != null && usr.UserPassword == Model.UserPassword)
                {
                    Model.UserTypeID = usr.UserTypeID;
                    Model.UserID = usr.UserID;
                    Model.isDelete = usr.isDelete;

                }

            }
            catch (Exception ex)
            {
                string d = ex.Message;
            }

            return RedirectToAction("Index","Home");
        }

        //Creates a User
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="Username,UserPassword,UserEmail,UserPhoneNumber,IsActive,IsDelete,CreatedDate,ModifiedDate")] UserModel model)
        {
            
            var um = new UserModel
            {
               
            };
            try
            {
                var usr = g.UserTables.Where(s => s.UserName == model.UserName).FirstOrDefault();
                var UserObj = new UserModel();

                UserObj.UserPassword = model.UserPassword;
                UserObj.UserName = model.UserName;
                UserObj.UserEmail = model.UserEmail;
                UserObj.UserPhoneNumber = model.UserPhoneNumber;
                UserObj.isActive = "Y";
                UserObj.UserTypeID = 1;
                UserObj.isDelete = 0;
                UserObj.CreatedDate = DateTime.Now;
                UserObj.ModifiedDate = DateTime.Now;
                g.UserTables.Add(UserObj);
                if(usr == null)
                {
                    ViewBag.message = "Registration Success";
                    g.SaveChanges();
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                string d = ex.Message;
            }
            return RedirectToAction("Registration","Registration");
        }

      
        
      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                g.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
