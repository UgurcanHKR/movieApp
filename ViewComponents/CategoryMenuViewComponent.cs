using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movieApp.Data;

namespace movieApp.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View(CategoryRepository.Categories);
        }  
    }
}