using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class Todocontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
    }
}