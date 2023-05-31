using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class Singleton
    {
        /*
         Singleton: Un único objeto en toda la aplicación
         */
        private readonly static Singleton _instance = new Singleton();
        public static Singleton Instance
        {
            get
            {
                return _instance;

            }
        }

        private Singleton()
        {
        }
    }
}
