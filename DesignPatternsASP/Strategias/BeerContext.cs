using DesignPatternsASP.Models.ViewModels;
using DesignPatterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Strategias
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;
        public IBeerStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }

        public BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerVM, unitOfWork);
        }
    }
}
