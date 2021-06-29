using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult SanPham()
        {
             return View(ql.SanPhams.ToList());
        }


    }
}
