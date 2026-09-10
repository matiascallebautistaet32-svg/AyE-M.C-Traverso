using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol arbolitox = new Arbol();

            arbolitox.insertar(50);
            arbolitox.insertar(25);
            arbolitox.insertar(15);
            arbolitox.insertar(80);
            arbolitox.insertar(45);
            arbolitox.insertar(30);
            arbolitox.insertar(15);

            Console.WriteLine($"Mínimo: {arbolitox.ObtenerMinimo()}"); 
            Console.WriteLine($"Máximo: {arbolitox.ObtenerMaximo()}"); 
            Console.WriteLine($"Cantidad de nodos: {arbolitox.ObtenerCantidadNodos()}"); 
            Console.WriteLine($"Altura del árbol: {arbolitox.ObtenerAltura()}");
            Console.WriteLine($"Cantidad de hojas: {arbolitox.ContarHojas()}"); 
            Console.WriteLine($"¿Es árbol BST válido?: {arbolitox.EsValido()}"); 

         
            arbolitox.Eliminar(25);
            Console.WriteLine($"Nodos tras eliminar 25: {arbolitox.ObtenerCantidadNodos()}"); 
        }
    }
}

