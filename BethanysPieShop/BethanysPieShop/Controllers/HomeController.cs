﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly PieRepository pieRepository;

        public HomeController(PieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var pies = pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel
            {
                Title = "Pie Overview",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }
    }
}
