using System;

namespace Singletonejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton singleton =  MySingleton.GetInstance();
        }
    }
}
