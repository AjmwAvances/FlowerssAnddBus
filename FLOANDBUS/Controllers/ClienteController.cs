using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FLOANDBUS.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/
        public ActionResult Index()
        {
            return View();

             }
        public ActionResult Email()
        {
            return View();
        }
	}
}