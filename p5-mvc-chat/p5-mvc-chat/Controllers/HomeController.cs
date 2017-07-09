using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using p5_mvc_chat.Models;

namespace p5_mvc_chat.Controllers
{
    public class HomeController : Controller
    {
        ChatDbContext.ChatDbContext _chatDb = new ChatDbContext.ChatDbContext();
        
        // get
        [HttpGet]
        public ActionResult Index()
        {
            return View(_chatDb.Chats.ToList());
        }

        [HttpPost]
        public string GetList()
        {
            string json = System.Web.Helpers.Json.Encode(_chatDb.Chats.ToList()
                .OrderByDescending(model => model.Createtime).Take(30).OrderBy(model => model.Createtime));
            return json;
        }
        
        [HttpPost]
        public string AddCommet(Chat chat)
        {
            //if (!ModelState.IsValid) return "error";
            chat.Createtime = DateTime.Now;
            chat.Ip = Request.UserHostAddress;
            _chatDb.Chats.Add(chat);
            _chatDb.SaveChanges();
            return "success";
        }
    }
}