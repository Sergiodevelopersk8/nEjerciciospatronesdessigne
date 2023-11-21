using System;

namespace ejercicioscsharp
{
    class Program
    {

        int[] vectores;


       public void Cargar()
        {
            Console.WriteLine("Metodo de Burbuja");
            Console.Write("Cuantos longitud del vector: ");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vectores = new int[cant];
            for (int f = 0; f < vectores.Length; f++)
            {
                Console.WriteLine("ingrese el elemento" + (f + 1) + ": ");
                linea = Console.ReadLine();
                vectores[f] = int.Parse(linea);
            }
        }


      public  void Burbuja()
        {
            int t;

            for(int a = 1; a < vectores.Length; a++)
            {
                for (int b = vectores.Length - 1; b >= a; b--)
                {
                    if(vectores[b-1] > vectores[b])
                    {
                        t = vectores[b - 1];
                       vectores[b - 1] = vectores[b];
                        vectores[b] = t;
                    }
                }
            }

        }


        public void Imprimir()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < vectores.Length; f++)
            {
                Console.Write(vectores[f] + "  ");
            }
            Console.ReadKey();
        }

        public bool PalindromosMetodo(string pali){

            int longitud = pali.Length;
            
            for (int i = 0; i < longitud / 2; i++)
            {
                if(pali[i] != pali[longitud - i - 1])
                {
                    return false;
                }

            
            }

            return true;
        } 


        public void ParoInpar()
        {
            Console.WriteLine("Metodo de par o inpar");
            Console.Write("Cuantos longitud del vector: ");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vectores = new int[cant];
            for (int f = 0; f < vectores.Length; f++)
            {
                Console.WriteLine("ingrese el elemento " + (f + 1) + "  : ");
                linea = Console.ReadLine();
                vectores[f] = int.Parse(linea);
                if(int.Parse(linea) % 2 == 0)
                {
                    Console.WriteLine(linea + "  es par  ");
                }
                else
                {
                    Console.WriteLine(linea + "   no es par   ");

                }
            }
            
        }



        static void Main(string[] args)
        {
            Program metodos = new Program();

            //metodos.Cargar();
            //metodos.Burbuja();
            //metodos.Imprimir();
            metodos.ParoInpar();
            //Console.WriteLine("Introduce una cadena: ");
            //string input = Console.ReadLine();
            //if (metodos.PalindromosMetodo(input))
            //{
            //    Console.WriteLine("La cadena es un palíndromo");
            //}
            //else
            //{
            //    Console.WriteLine("La cadena no es un palíndromo");
            //}
            Console.ReadKey();

        }
    }
}
