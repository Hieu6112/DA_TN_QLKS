using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DATN_QLKS.Models;

namespace DATN_QLKS.Areas.Admin.Controllers
{
    public class TinNhanController : Controller
    {
        private dataQLKSEntities db = new dataQLKSEntities();
        // GET: Admin/TinNhan
        public ActionResult Index()
        {
            return View(db.tblTinNhans.ToList());
        }

        // GET: TinNhan/Details
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblTinNhan tblTinNhan = db.tblTinNhans.Find(long.Parse(id));
            if (tblTinNhan == null)
            {
                return HttpNotFound();
            }
            return View(tblTinNhan);
        }
    }
}