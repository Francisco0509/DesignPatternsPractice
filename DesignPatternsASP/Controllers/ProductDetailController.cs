using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earn;

namespace DesignPatternsASP.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory,
                                        ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }
        public IActionResult Index(decimal total)
        {
            //Factories (Usando factory sin inyección de dependencias)
            //LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            //ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);

            //Products => Objeto que generan las fabricas
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            //total
            ViewBag.TotalLocal = total + localEarn.Earn(total);
            ViewBag.TotalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
