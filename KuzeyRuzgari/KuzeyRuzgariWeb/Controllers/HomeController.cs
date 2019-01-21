using KuzeyRuzgariWeb.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KuzeyRuzgariWeb.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.ProductClient productclient = new ServiceReference1.ProductClient();
        ServiceReference1.CategoryClient categoryclient = new ServiceReference1.CategoryClient();
        
        public ActionResult Index()
        {
            Urun[] urunler = productclient.GetAllProduct();

            return View(urunler);
        }
    }
}