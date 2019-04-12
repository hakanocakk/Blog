using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _190410_BlogV1.Areas.AdminPaneli.Controllers
{
    public class EtiketlerController : Controller
    {
        Bloghi304DBEntities db = new Bloghi304DBEntities();
        // GET: AdminPaneli/Etiketler
        public ActionResult EtiketListesiIndex()
        {
            return View(db.Etiketler.ToList());
        }
    }
}