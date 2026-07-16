namespace ConsoleApp1
{
    public struct Jugador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Cant_goles { get; set; }
        public double Cant_disp { get; set; }
        public int Numero { get; set; }
        public string Posicion { get; set; }
        public string Equipo { get; set; }

        public Jugador(string nombre, string apellido, double cant_goles, double cant_disp, int numero, string posicion, string equipo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cant_goles = cant_goles;
            Cant_disp = cant_disp;
            Numero = numero;
            Posicion = posicion;
            Equipo = equipo;
        }
        public double indiceataque()
        {
            double indice;
            indice = (Cant_goles / Cant_disp) * 100;
            return indice;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jugador[] jugadores = new Jugador[10];
            {
                jugadores[0] = new Jugador("Lionel", "Messi", 8, 18, 10, "Mediapunta","Argentina");
                jugadores[1] = new Jugador("Kylian", "Mbappe", 8, 19, 10, "Delantero","Francia");
                jugadores[2] = new Jugador("Erling", "Haaland", 7, 13, 9, "Delantero","Noruega");
                jugadores[3] = new Jugador("Harry", "Kane", 6, 12, 9, "Delantero","Inglaterra");
                jugadores[4] = new Jugador("Jude", "Bellingham", 6, 11, 10, "Mediapunta","Inglaterra");
                jugadores[5] = new Jugador("Ousmane", "Dembele", 5, 8, 7, "Extremo derecho","Francia");
                jugadores[6] = new Jugador("Mikel", "Oyarrazabal", 4, 11, 21, "Extremo izquierdo","España");
                jugadores[7] = new Jugador("Vinicius", "Junior", 4, 11, 7, "Extremo izquierdo","Brasil");
                jugadores[8] = new Jugador("Julian", "Quiñones", 4, 6, 16, "Extremo izquierdo", "Mexico");
                jugadores[9] = new Jugador("Ismaila", "Sarr", 4, 6, 18, "Extremo derecho","Senegal");
            };
     
            Console.WriteLine();

            Jugador mejorAtacante = jugadores[0];
            
            for (int i = 1; i < jugadores.Length; i++)
            {
                if (jugadores[i].indiceataque() > mejorAtacante.indiceataque())
                {
                    mejorAtacante = jugadores[i];
                }
            }

            Console.WriteLine("El jugador con el mejor indice de ataque es: ");
            Console.WriteLine($"Nombre: {mejorAtacante.Nombre} {mejorAtacante.Apellido}");
            Console.WriteLine($"Equipo: {mejorAtacante.Equipo}");
            Console.WriteLine($"Numero: {mejorAtacante.Numero}");
            Console.WriteLine($"Posicion: {mejorAtacante.Posicion}");
            Console.WriteLine($"Indice de Ataque: {mejorAtacante.indiceataque}");

            Console.ReadLine();
        }
    }
}

