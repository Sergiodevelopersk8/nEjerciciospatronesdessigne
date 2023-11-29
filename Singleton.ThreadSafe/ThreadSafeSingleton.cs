using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.ThreadSafe
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance; 
        private static readonly object _lock = new object();

        private ThreadSafeSingleton()
        {

        }

        private static ThreadSafeSingleton GetInstance()
        {
            if(_instance == null)
            {
                //usamos la llave lock esto es de c# en otros lenguajes se  busca lo similar
                //lock es un hilo y nos aseguramos de que se use la instancia una por hilo
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }
            return _instance;
        }

    }
}
