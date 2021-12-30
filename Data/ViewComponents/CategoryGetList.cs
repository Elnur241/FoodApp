using FoodApp.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Data.ViewComponents
{
    public class CategoryGetList: ViewComponent
    {
   public IViewComponentResult Invoke()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var list = categoryRepository.Tlists();
            return View(list);
        }
    }
}
