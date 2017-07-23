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
        ChatDbContext.ChatDbContext _chatDb = new ChatDbContext.ChatDbContext();

        // get
        [HttpGet]
        public ActionResult Index()
        {
            return View(_chatDb.AdminUsers.Include("AdminRights").ToList());
        }

        [HttpPost]
        public string GetList()
        {
            string json = System.Web.Helpers.Json.Encode(_chatDb.AdminUsers.ToList());
            return json;
        }
        
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(AdminUser user)
        {
            if (!ModelState.IsValid) return View();
            user.Ip = Request.UserHostAddress;
            _chatDb.AdminUsers.Add(user);
            _chatDb.SaveChanges();
            return View(user);
        }
    }
}