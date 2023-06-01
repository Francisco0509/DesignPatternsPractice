using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Strategias
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerVM.Name;
            beer.Style = beerVM.Style;
            beer.BrandId = (Guid)beerVM.BrandId;

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
                
        }
    }
}
