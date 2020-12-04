﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SallesWebMVC.Models;

namespace SallesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Fashion"});
            list.Add(new Department { Id = 2, Name = "Eletronics" });


            return View(list);
        }
    }
}
