using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeThongSieuThi()
        {
            return View();
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult lienHe()
        {
            return View();
        }

    }
}
