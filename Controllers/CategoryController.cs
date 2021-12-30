using FoodApp.Data.Models;
using FoodApp.Data.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Controllers
{
    
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();

  
        public IActionResult Index()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            return View(categoryRepository.Tlists());
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category cat)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCategory");
            }
            categoryRepository.Tadd(cat);
            return RedirectToAction("Index");
        }
        public IActionResult getCategory(int id)
        {
           Category category= categoryRepository.Tget(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult updateCategory(Category category)
        {
            Category cat=categoryRepository.Tget(category.Id);
            cat.Name = category.Name;
            cat.Description = category.Description;
            cat.Status = true;
            categoryRepository.Tupdate(cat);
            return RedirectToAction("index");
        }
        public IActionResult deleteCategory(int id)
        {
            categoryRepository.Tdelete(id);
            return RedirectToAction("Index");
        }
    }
}
