using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using RestaurantCore.BLL;

namespace RestaurantCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.RandomRestaurant = RestaurantData.Instance.GetRandomRestaurant();
            return View();
        }

        
    }
}
