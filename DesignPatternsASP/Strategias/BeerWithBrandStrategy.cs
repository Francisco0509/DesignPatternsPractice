using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Strategias
{
    public class BeerWithBrandStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerVM.Name;
            beer.Style = beerVM.Style;

            var brand = new Brand();
            brand.Name = beerVM.OtherBrand;
            brand.BrandId = Guid.NewGuid();
            beer.BrandId = brand.BrandId;

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);

            unitOfWork.Save();
        }
    }
}
