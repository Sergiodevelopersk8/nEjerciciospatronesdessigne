using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEjemplo2
{
    public class MySingleton
    {
        private static MySingleton _instance;

        public Guid Id { get; private set; }

        private MySingleton()
        {
            /*etso crea un nuevo valor aleatorio 
             puesto que guid es unico*/
            Id = Guid.NewGuid();
        }


        public static MySingleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new MySingleton();
            }

            return _instance;
        }


    }
}
