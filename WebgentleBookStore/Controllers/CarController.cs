using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebgentleBookStore.Models;
using WebgentleBookStore.Repository;

namespace WebgentleBookStore.Controllers
{
    public class CarController : Controller
    {
        private readonly CarRespositroy _carRespositroy = null;
        public CarController(CarRespositroy carRespositroy)
        {
            _carRespositroy = carRespositroy;

        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddCar(bool isSuccess = false, int carId = 0)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.carId = carId; 
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(CarModel carModel)
        {
           int id =  _carRespositroy.AddNewCar(carModel);
            if (id > 0)
            {
                return RedirectToAction(nameof(AddCar),new { isSuccess = true, carId = id });
            }
            return View();
        }
    }
}
