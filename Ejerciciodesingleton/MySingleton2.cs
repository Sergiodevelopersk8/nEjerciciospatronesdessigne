using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciodesingleton
{
    public class MySingleton2
    {
        private static MySingleton2 _instance;


        public Guid Id { get; private set; }
        private MySingleton2()
        {
            Id = Guid.NewGuid();
        }

        public static MySingleton2 GetInstance()
        {
            if( _instance == null) {

                _instance = new MySingleton2();

            }

            return _instance;
        }

    }
}
