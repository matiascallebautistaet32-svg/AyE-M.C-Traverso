using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace ConsoleAppPersonaje
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<Mago> hechizosquetiro = new Stack<Mago>();

   
            Mago Mago1 = new Mago(100, 100, "Hechizo de Veneno");
            Mago Mago2 = new Mago(100, 90, "Hechizo de Hielo");
            Mago Mago3 = new Mago(100, 75, "Hechizo de Basura");


            hechizosquetiro.Push(Mago1);
            hechizosquetiro.Push(Mago2);
            hechizosquetiro.Push(Mago3);

   
            MostrarHistorial(hechizosquetiro);
            Console.WriteLine();
            Golpear(hechizosquetiro);
            Console.WriteLine();
            VolverEnElTiempo(hechizosquetiro);
        }

      
        public static void MostrarHistorial(Stack<Mago> pila)
        {
            foreach (Mago a in pila)
            {
                Console.WriteLine($"Hechizo: {a.UltimoHechizo}  Vida Actual: {a.VidaActual} Vida Total: {a.VidaTotal}");
            }
        }

        public static void VolverEnElTiempo(Stack<Mago> pila)
        {
                Mago borrado = pila.Pop();
                Console.WriteLine($"Hechizo borrado: {borrado.UltimoHechizo}");
        }
            
        
        public static void Golpear(Stack<Mago> pila)
        {
            
                Mago actual = pila.Peek();

                int nuevaVida = actual.VidaActual - 20;
      
                Mago Golpeado = new Mago(actual.VidaTotal, nuevaVida, "Espinas");

                pila.Push(Golpeado);
                Console.WriteLine($"Vida Actual: {Golpeado.VidaActual} Vida Total: {Golpeado.VidaTotal}");
            }
        }
    }


