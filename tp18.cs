namespace ConsoleApp5
{
    internal class Program
    {
        public struct Punto2D
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Punto2D(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Mostrar()
            {
                Console.WriteLine($"Posición: ({X}, {Y})");
            }

        }
        static void Main(string[] args)
        {
            Punto2D punto1 = new Punto2D(5, 10);
            punto1.Mostrar();
        }
    }
}