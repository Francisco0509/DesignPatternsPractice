﻿using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASP.Configuration;
using DesignPatternsASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tools;

namespace DesignPatternsASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _config;
        private readonly IRepository<Beer> _repository;

        public HomeController(IOptions<MyConfig> config,
                              IRepository<Beer> repository)
        {
            _config = config;
            _repository = repository;
        }

        public IActionResult Index()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Entró a Index");

            IEnumerable<Beer> lst = _repository.Get();
            return View("Index", lst);
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Entró a Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
