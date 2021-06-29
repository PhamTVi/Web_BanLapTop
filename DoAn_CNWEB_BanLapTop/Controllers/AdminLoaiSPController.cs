using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_CNWEB_BanLapTop.Models;

namespace DoAn_CNWEB_BanLapTop.Controllers
{
    public class AdminLoaiSPController : Controller
    {
        //
        // GET: /AdminLoaiSP/

        public ActionResult Index()
        {
            return View();
        }
        QL_LapTopDataContext ql = new QL_LapTopDataContext();
        public ActionResult ShowEmplParameter(int id)
        {
            var listSP = ql.SanPhams.Where(loai => loai.MaLoai == id).ToList();
            return View(listSP);
        }
        public ActionResult hienThiLoaiSP()
        {
            return View(ql.Loais.ToList());
        }
        
    }
}
