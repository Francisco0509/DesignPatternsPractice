using DesignPatterns.DependencyInjectionPattern;
using System;

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
            var beer = new Beer("Pikantus", "Erdinger");
            var dringWithBeer = new DrinkWithBeer(10, 1, beer);
            dringWithBeer.Build();

            Console.ReadKey();
        }
    }
}
