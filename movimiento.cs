using System.Security.Cryptography.X509Certificates;
using ConsoleApp2;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Ubicacion> historialUbi = new Stack<Ubicacion>();

            Ubicacion ubicacion1 = new Ubicacion(10, 13, "Jungla");
            historialUbi.Push(ubicacion1);

            Ubicacion ubicacion2 = new Ubicacion(50, 33, "Llanura");
            historialUbi.Push(ubicacion2);

            Ubicacion ubicacion3 = new Ubicacion(1, 93, "Bosque");
            historialUbi.Push(ubicacion3);

            foreach (Ubicacion ubicacioN in historialUbi)
            {
                Console.WriteLine($"Coordenada X: {ubicacioN.x} Coordenada Y: {ubicacioN.y} nombre de la zona: {ubicacioN.nombre_zona}");
            }

            Ubicacion retroceso = historialUbi.Pop();
            Console.WriteLine($"Ubicacion removida: {retroceso.nombre_zona} - {retroceso.x} - {retroceso.y}");

            Ubicacion actual = historialUbi.Peek();
            Console.WriteLine($"Ubicacion que quedo en la cima: {actual.nombre_zona} - {actual.x} - {actual.y}");
        }
    }
}