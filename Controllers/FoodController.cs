using FoodApp.Data.Models;
using FoodApp.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace FoodApp.Controllers
{

    public class FoodController : Controller
    {
        Context context = new Context();
        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index(int page=1)
        {
            FoodRepository foodRepository = new FoodRepository();
            return View(foodRepository.TList("Category").ToPagedList(page, 3));
        }
        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> list = context.categories.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList() ;
            ViewBag.foodbag = list;
            return View();
        }
        [HttpPost]
        public IActionResult AddFood(Food food)
        {
            foodRepository.Tadd(food);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFood(int  id)
        {
            foodRepository.Tdelete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult getFood(int id)
        {
            Food food = foodRepository.Tget(id);
            List<SelectListItem> list = context.categories.Select(y => new SelectListItem
            {
                Text = y.Name,
                Value = y.Id.ToString()
            }).ToList() ;
            ViewBag.foodbag2 = list;
            return View(food);
        }
        [HttpPost]
        public IActionResult updateFood(Food food)
        {
            Food food2 = foodRepository.Tget(food.id);
            food2.name = food.name;
            food2.CategoryId = food.CategoryId;
            food2.Description = food.Description;
            food2.IamgeUrl = food.IamgeUrl;
            food2.Price = food.Price;
            food2.Stock = food.Stock;
            food2.name = food.name;
            foodRepository.Tupdate(food2);
            return RedirectToAction("Index");
        }
    }
}
