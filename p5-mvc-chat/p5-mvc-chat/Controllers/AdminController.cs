using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using p5_mvc_chat.Controllers.ChatDbContext;
using p5_mvc_chat.Models;

namespace p5_mvc_chat.Controllers
{
    public class AdminController : Controller
    {
        DbContext.AdminContext _admin = new DbContext.AdminContext();
        
        // get
        [HttpGet]
        public ActionResult Index()
        {
            return View(_admin.AdminUsers.ToList());
        }

        [HttpPost]
        public string GetList()
        {
            string json = System.Web.Helpers.Json.Encode(_admin.AdminUsers.ToList());
            return json;
        }
        
        [HttpPost]
        public string AddCommet(AdminUser user)
        {
            if (!ModelState.IsValid) return "error";
            user.Ip = Request.UserHostAddress;
            _admin.AdminUsers.Add(user);
            _admin.SaveChanges();
            return "success";
        }
    }
}