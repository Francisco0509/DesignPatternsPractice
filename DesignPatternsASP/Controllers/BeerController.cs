using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViewModels;
using DesignPatternsASP.Strategias;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                               select new BeerViewModel
                                               {
                                                   Id = d.BeerId,
                                                   Name = d.Name,
                                                   Style = d.Style
                                               };
            return View("Index", beers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            GetBrandData();
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerVM)
        {
            if (!ModelState.IsValid)
            {
                GetBrandData();
                return View("Add", beerVM);
            }

            var context = beerVM.BrandId == null ?
                        new BeerContext(new BeerWithBrandStrategy()) :
                        new BeerContext(new BeerStrategy());
            context.Add(beerVM, _unitOfWork);

            return RedirectToAction("Index");
        }

        #region HELPERS
        private void GetBrandData()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        }
        #endregion
    }
}
