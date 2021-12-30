using FoodApp.Data;
using FoodApp.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Controllers
{
   
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult getChart()
        {
            return Json(lists());
        }
        public List<Class1> lists()
        {
 
            List<Class1> list = new List<Class1>();
            list.Add(new Class1() { 
            proname="Computer",
            stock=150
            });
            list.Add(new Class1 { 
            proname="Usb",
            stock=230
            });
            list.Add(new Class1
            {
                proname = "Lcd",
                stock = 230
            });
            return list;
        }
        public IActionResult Index3()
        {
            return View();
        }
        public IActionResult getChart2()
        {
            return Json(Lists2());
        }
        public List<Class2> Lists2()
        {
            List<Class2> list = new List<Class2>();
            using (var c4 = new Context())
            {
                list = c4.foods.Select(X => new Class2()
                {
                    foodname = X.name,
                    stock = X.Stock
                }).ToList();
                return list;
            }
        }
        public IActionResult statistic()
        {
            Context context = new Context();
          int d1= context.foods.Count();
            ViewBag.d1 = d1;

            int d2 = context.categories.Count();
            ViewBag.d2 = d2;

            int fI = context.categories.Where(x => x.Name == "Fruits").Select(z => z.Id).FirstOrDefault();
           int d3 = context.foods.Where(x=>x.CategoryId== fI).Count();
            ViewBag.d3 = d3;
            int vI = context.categories.Where(x => x.Name == "Vegetables").Select(z => z.Id).FirstOrDefault();
            int d4 = context.foods.Where(X=>X.CategoryId==vI).Count();
            ViewBag.d4 = d4;

            int d5 = context.foods.Select(x=>x.Stock).Sum();
            ViewBag.d5 = d5;

            int fastId = context.categories.Where(x => x.Name == "FastFood").Select(z => z.Id).FirstOrDefault();
            int d6 = context.foods.Where(x => x.CategoryId == fastId).Count();
            ViewBag.d6 = d6;

            string d7 = context.foods.OrderByDescending(x => x.Stock).Select(y => y.name).FirstOrDefault();
            ViewBag.d7 = d7;
            string d8 = context.foods.OrderBy(x => x.Stock).Select(y => y.name).FirstOrDefault();
            ViewBag.d8 = d8;

            string d9 = context.foods.Average(x=>x.Price).ToString("0.00");
            ViewBag.d9 = d9;

            int d10 = context.foods.Where(x => x.category.Name == "Fruits").Sum(x => x.Stock);
            ViewBag.d10 = d10;

            int d11 = context.foods.Where(x => x.category.Name == "Vegetables").Sum(x => x.Stock);
            ViewBag.d11 = d11;
            string d12 = context.foods.OrderByDescending(x => x.Price).Select(y => y.name).FirstOrDefault();
            ViewBag.d12 = d12;


            return View();
        }

    }
}
