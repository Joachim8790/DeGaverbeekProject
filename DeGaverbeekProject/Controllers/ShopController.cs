using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeGaverbeekProject.Controllers
{
    public class ShopController : Controller
    {
        // GET: Products
        public ActionResult Products()
        {
            return View();
        }
        // GET: Winkelmandje
        public ActionResult ShoppingBasket()
        {
            return View();
        }
        public ActionResult OrderHistory()
        {
            return View();
        }
    }
}