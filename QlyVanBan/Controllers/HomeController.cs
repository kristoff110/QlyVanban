using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
using PagedList;

namespace QlyVanBan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var dao = new VanBanDao();
            var model = dao.ListAllPaging(page, pageSize);
            return View(model);
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new VanBanDao().Delete(id);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult MultiDelete(int[] id)
        {
            var dao = new VanBanDao();
            var model = dao.MultiDelete(id);
            ViewBag.ID = id;
            return RedirectToAction("Index");
        }
    }
}