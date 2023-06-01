using DesignPatternsASP.Models.ViewModels;
using DesignPatterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Strategias
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork);
    }
}
