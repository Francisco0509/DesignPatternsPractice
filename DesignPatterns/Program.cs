//using DesignPatterns.DependencyInjectionPattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.StatePattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.UnitOfWorkPattern;
using System;
using System.Linq;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            //var singleton = Singleton.Singleton.Instance;
            //var log = Singleton.Log.Instance;
            //log.Save("Probando el patrón Singleton");
            //log.Save("Con C#");

            //Factory
            //SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            //SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            //ISale sale1 = storeSaleFactory.GetSale();
            //sale1.Sell(15);

            //ISale sale2 = internetSaleFactory.GetSale();
            //sale2.Sell(15);

            //Dependency Injection
            //var beer = new Beer("Pikantus", "Erdinger");
            //var dringWithBeer = new DrinkWithBeer(10, 1, beer);
            //dringWithBeer.Build();



            //using (var context = new DesignPatternsContext())
            //{
            //var list = context.Beers.ToList();
            //foreach (var beer in list)
            //{
            //    Console.WriteLine(beer.Name);
            //}

            //var beerRepository = new BeerRepository(context);
            //var beer = new Beer();
            //beer.Name = "Corona";
            //beer.Style = "Pilsner";

            //beerRepository.Add(beer);
            //beerRepository.Save();

            //foreach (var item in beerRepository.Get())
            //{
            //    Console.WriteLine($"Cerveza {item.Name} de estilo {item.Style}");
            //}

            //var beerRepository = new Repository<Beer>(context);
            //var beer = new Beer() { Name = "Fuller", Style = "Strong Ale" };
            //beerRepository.Add(beer);
            //beerRepository.Save();

            //foreach (var item in beerRepository.Get())
            //{
            //    Console.WriteLine($"Cerveza {item.Name} de estilo {item.Style}");
            //}

            //var brandRepository = new Repository<Brand>(context);

            //var brand = new Brand();
            //brand.Name = "Fuller";
            //brandRepository.Add(brand);
            //brandRepository.Save();
            //foreach (var item in brandRepository.Get())
            //{
            //    Console.WriteLine($"La nueva marca de cerveza {item.Name}");
            //}

            /************/
            /*UnitOfWork*/
            /************/
            //var unitOfWork = new UnitOfWork(context);
            //var beers = unitOfWork.Beers;
            //var beer = new Beer()
            //{
            //    Name = "Fuller",
            //    Style = "Porter"
            //};

            //beers.Add(beer);

            //var brands = unitOfWork.Brands;
            //var brand = new Brand()
            //{
            //    Name = "Fuller"
            //};

            //brands.Add(brand);

            //unitOfWork.Save();
            //}

            //Patrón Strategy
            //var context = new Context(new CarStrategy());
            //context.Run();
            //context.Strategy = new MotoStrategy();
            //context.Run();
            //context.Strategy = new BicycleStrategy();
            //context.Run();

            //Patrón Builder
            //var builder = new PreparedAlcoholicDrinksConcrete();
            //var barmanDirector = new BarmanDirector(builder);

            //barmanDirector.PrepareMargarita();

            //var preparedDrink = builder.GetPreparedDrink();
            //Console.WriteLine(preparedDrink.Result);

            //barmanDirector.PreparePinaColada();
            //preparedDrink = builder.GetPreparedDrink();
            //Console.WriteLine(preparedDrink.Result);

            //Patrón State
            var customerContext = new CustomerContext();
            Console.WriteLine(customerContext.GetState());
            customerContext.Request(100);
            Console.WriteLine(customerContext.GetState());
            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());
            customerContext.Request(100);
            Console.WriteLine(customerContext.GetState());
            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());
            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());
            Console.ReadKey();
        }
    }
}
