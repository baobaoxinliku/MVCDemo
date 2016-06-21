using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PagedList;
using System.Configuration;
using System.Web.Security;

namespace MVCDemo.Controllers
{
    public class AccountController : Controller
    {
        private DAL.AccountContext db = new DAL.AccountContext();
        // GET: Account
        
        public ActionResult Index()
        {
            ViewModels.IndexViewModel ivm = new ViewModels.IndexViewModel();
            ivm.UserInfos = db.UserInfo.OrderByDescending(a => a.UserName).Skip(0).Take(6).ToList();
            ivm.ScenicInfos = db.ScenicInfo.OrderByDescending(a => a.ScenicName).Skip(0).Take(10).ToList();
            return View(ivm);
        }

        [Authorize]
        public ActionResult IndexScenic(string Search)
        {
            List<Models.ScenicInfo> ScenicInfos;
            if (!string.IsNullOrEmpty(Search))
            {
                ScenicInfos = db.ScenicInfo.Where(u => u.ScenicName.Contains(Search)).ToList();
            }
            else
            {
                ScenicInfos = db.ScenicInfo.ToList();
            }
            ViewModels.AccountListViewModel aLVM = new ViewModels.AccountListViewModel();
            aLVM.ScenicInfo = ScenicInfos;
            return View(aLVM);
        }
        [Authorize]
        public ActionResult IndexUser(string Search)
        {
            List<Models.UserInfo> UserInfos;
            if (!string.IsNullOrEmpty(Search))
            {
                UserInfos = db.UserInfo.Where(u => u.UserName.Contains(Search)).ToList();
            }
            else
            {
                UserInfos = db.UserInfo.ToList();
            }
            ViewModels.AccountListViewModel aLVM = new ViewModels.AccountListViewModel();
            aLVM.UserInfo = UserInfos;
            return View(aLVM);
        }

        public ActionResult IndexScenic1(int? page)
        {
            var acc = db.ScenicInfo;
            int pageNumber = page ?? 1;
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]);
            var acc1 = acc.OrderBy(x => x.ScenicName);
            IPagedList<Models.ScenicInfo> pageList = acc1.ToPagedList(pageNumber,pageSize);
            return View(pageList);

        }
        public ActionResult IndexUser1(int? page)
        {
            var acc = db.UserInfo;
            int pageNumber = page ?? 1;
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]);
            var acc1 = acc.OrderBy(x => x.UserName);
            IPagedList<Models.UserInfo> pageList = acc1.ToPagedList(pageNumber, pageSize);
            return View(pageList);

        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.UserInfo userinfo)
        {
            var user = db.UserInfo.Where(b => b.UserName == userinfo.UserName & b.UserPwd == userinfo.UserPwd);
            if (user.Count() > 0)
            {
                ViewBag.LoginState = "登录成功";
                FormsAuthentication.SetAuthCookie(userinfo.UserName, false);
                Session["UserID"] = user.First().UserName;
                return RedirectToAction("IndexScenic");
            }
            else
            {
                ViewBag.LoginState = "登录失败";
                ModelState.AddModelError("CredentitalError","Invalid Username or Password"); 
                return View();
            }         
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.UserInfo acc)
        {
            db.UserInfo.Add(acc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DetailScenic(int id)
        {
            Models.ScenicInfo acc = db.ScenicInfo.Find(id);
            return View(acc);
        }
        public ActionResult DetailUser(int ? id)
        {
            Models.UserInfo acc = db.UserInfo.Find(id);
            return View(acc);
        }

        public ActionResult EditScenic(int id)
        {
            Models.ScenicInfo acc = db.ScenicInfo.Find(id);
            return View(acc);
        }
        public ActionResult EditUser(int id)
        {
            Models.UserInfo acc = db.UserInfo.Find(id);
            return View(acc);
        }

        [HttpPost]
        public ActionResult EditScenic(Models.ScenicInfo acc)
        {
            db.Entry(acc).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("IndexScenic");
        }
        [HttpPost]
        public ActionResult EditUser(Models.UserInfo acc)
        {
            db.Entry(acc).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("IndexUser");
        }

        public ActionResult DeleteScenic(int id)
        {
            Models.ScenicInfo acc = db.ScenicInfo.Find(id);
            return View(acc);
        }
        public ActionResult DeleteUser(int id)
        {
            Models.UserInfo acc = db.UserInfo.Find(id);
            return View(acc);
        }

        [HttpPost, ActionName("DeleteScenic")]
        public ActionResult DeleteScenicConfirmed(int id)
        {
            Models.ScenicInfo acc = db.ScenicInfo.Find(id);
            db.ScenicInfo.Remove(acc);
            db.SaveChanges();
            return RedirectToAction("IndexScenic");
        }
        [HttpPost, ActionName("DeleteUser")]
        public ActionResult DeleteUserConfirmed(int id)
        {
            Models.UserInfo acc = db.UserInfo.Find(id);
            db.UserInfo.Remove(acc);
            db.SaveChanges();
            return RedirectToAction("IndexUser");
        }

        [Authorize]
        public ActionResult AddScenic()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddScenic(Models.ScenicInfo acc)
        {
            db.ScenicInfo.Add(acc);
            db.SaveChanges();
            return RedirectToAction("IndexScenic");
        }

        public ActionResult GetAddAdminLink()
        {
            if (User.Identity.Name == "admin")
            {
                return PartialView("_AddAdminLink");
            }
            else
            {
                return new EmptyResult();
            }
        }
    }
}