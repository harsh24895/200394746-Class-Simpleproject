
using _200394746_Class_Simplepro.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200394746_Class_Simplepro.Controllers
{
    public class CarController : Controller
    {

        List<Car> carlist = new List<Car>()
        {
            new Car{Id=1, Brand ="Toyota",Model="Corolla",Type="Compact",Year=2017},
            new Car{Id=2, Brand ="Ford",Model="F-1150",Type="Truck",Year=2018},
            new Car{Id=3, Brand ="Dodge",Model="Caravan",Type="Minivan",Year=2019}

        };
        // GET: Car
        public ActionResult Index()
        {
            return View(carlist);
        }
        public ActionResult Details(int? id)
        {
            if (id == null || id > carlist.Count)
            {
                return Content("Invalid Car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carlist[ind];
            return View(car);

        }
    }
}