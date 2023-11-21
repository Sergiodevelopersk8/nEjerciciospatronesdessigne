using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletonejemplo1
{
    public class MySingleton
    {
        /*esto es una instancia */
        private static MySingleton _instance;


        /*constructor de la clase 
         al crear un constructor privado nos aseguramos 
        de que nadie pueda crear instancias de MySingleton y esto solo se puede
        einstanciar desde su propia clase*/
        private MySingleton()
        {
            /**/
        }

        public static MySingleton GetInstance()
        {
            /* validamos que solo sea una instancia */
            if(_instance == null)/*si _instance es nulo significa que vamos a crear una instancia */
            {
                _instance = new MySingleton();
            }

            /* retorna la instancia */
            return _instance;
        }


    }
}
