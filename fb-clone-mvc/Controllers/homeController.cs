using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fb_clone_mvc.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult home()
        {
            return View();
        }
        public ActionResult profile()
        {
            return View();
        }
        public ActionResult friends()
        {
            return View();
        }
        public ActionResult log_in()
        {
            return View();
        }
        public ActionResult sign_up()
        {
            return View();
        }
        public ActionResult Search_account()
        {
            return View();
        }
        public ActionResult view_friend_profile()
        {
            return View();
        }

        public ActionResult view_friend_request_profile()
        {
            return View();
        }
        public ActionResult edit_profile()
        {
            return View();
        }
        public ActionResult view_stranger()
        {
            return View();
        }

    }
}