﻿using Microsoft.AspNetCore.Mvc;
using Partical_views.Data;
using Partical_views.Models;
using Partical_views.ViewModels;
using System.Diagnostics;

namespace Partical_views.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context) 
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            SliderInfo sliderInfo = _context.SliderInfos.FirstOrDefault();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo
            };

            return View(sliders);
         }
    }
}