using System;

namespace SingletonEjemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton instancia1 = MySingleton.GetInstance();
            Console.WriteLine($"Instance 1 ID: {instancia1.Id}");
            MySingleton instancia2 = MySingleton.GetInstance();
            Console.WriteLine($"Instance 2 ID: {instancia2.Id}");
            MySingleton instancia3 = MySingleton.GetInstance();
            Console.WriteLine($"Instance 3 ID: {instancia3.Id}");
        }
    }
}
