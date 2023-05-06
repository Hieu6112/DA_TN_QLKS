using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DATN_QLKS.Models;
using System.Data;
using System.Data.Entity;


namespace DATN_QLKS.Controllers.Home
{
    public class RoomController : Controller
    {
        // GET: Room
        DATN_QLKS.Models.dataQLKSEntities db = new Models.dataQLKSEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Roomlist()
        {
            return View(db.tblLoaiPhongs.ToList());
        }

        // GET: LoaiPhong/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblLoaiPhong tblLoaiPhong = db.tblLoaiPhongs.Find(id);
            if (tblLoaiPhong == null)
            {
                return HttpNotFound();
            }
            return View(tblLoaiPhong);
        }
    }
}