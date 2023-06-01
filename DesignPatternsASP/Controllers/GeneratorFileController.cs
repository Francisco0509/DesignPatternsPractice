﻿using Microsoft.AspNetCore.Mvc;
using DesignPatterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Generator;

namespace DesignPatternsASP.Controllers
{
    public class GeneratorFileController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private GeneratorConcreteBuilder _generatorConcreteBuilder;

        public GeneratorFileController(IUnitOfWork unitOfWork,
                                        GeneratorConcreteBuilder generatorConcreteBuilder)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcreteBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(b => b.Name).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";
                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if (optionFile == 1)
                {
                    generatorDirector.CreateSimpleJsonGenerator(content, path);
                }
                else 
                {
                    generatorDirector.CreateSimplePipeGenerator(content, path);
                }

                var generator = _generatorConcreteBuilder.Getgenerator();
                generator.Save();

                return Json("Archivo generado");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
