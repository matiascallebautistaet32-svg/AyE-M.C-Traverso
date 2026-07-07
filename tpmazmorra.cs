namespace ConsoleAP
{
    class Personaje
    {
        public string Nombre { get; set; }
        public int Poder { get; set; }
        public List<string> Items { get; set; }

        public Personaje(string nombre, int poder)
        {
            Nombre = nombre;
            Poder = poder;
            Items = new List<string>();
        }

        public void IntentarRobar(Sala sala)
        {
            if (Poder > sala.Dificultad)
            {

                if (Items.Count < 20)
                {
                    Items.Add(sala.Item);
                    Poder += sala.PoderItem;
                    Console.WriteLine($"{Nombre} robo {sala.Item}, + {sala.PoderItem} Poder. Poder actual: {Poder}");
                }
                else
                {
                    Console.WriteLine($"{Nombre} supero la sala, su inventario esta lleno");
                }
            }
            else
            {
                Console.WriteLine($"{Nombre} no agarro nada, Dificultad de la sala: {sala.Dificultad}  Poder: {Poder}");
            }
        }

        public void MostrarInventario()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine(" Items: Ninguno");
            }
            else
            {
                Console.WriteLine(" Items: " + string.Join(", ", Items));
            }
        }
    }
    class Sala
    {
        public int Dificultad { get; set; }
        public string Item { get; set; }
        public int PoderItem { get; set; }

        public Sala(int dificultad, string item, int poderItem)
        {
            Dificultad = dificultad;
            Item = item;
            PoderItem = poderItem;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            Personaje p1 = new Personaje("Fede", 10);
            Personaje p2 = new Personaje("Cody", 10);

            string[] Items = { "Armadura", "Arma", "Pocion", "Amuleto" };

            for (int turno = 1; turno <= 20; turno++)
            {
                Console.WriteLine($"Turno {turno}");


                Sala salaP1 = GenerarSalaAleatoria(random, Items);
                p1.IntentarRobar(salaP1);


                Sala salaP2 = GenerarSalaAleatoria(random, Items);
                p2.IntentarRobar(salaP2);

                Console.WriteLine();
            }

            Console.WriteLine($"{p1.Nombre} Poder Final: {p1.Poder}");
            Console.WriteLine($"{p2.Nombre} Poder Final: {p2.Poder}");

            if (p1.Poder > p2.Poder)
            {
                AnunciarGanador(p1);
            }
            else if (p2.Poder > p1.Poder)
            {
                AnunciarGanador(p2);
            }
            else
            {
                Console.WriteLine("Hay empate");
                Console.WriteLine($"Inventario de {p1.Nombre}:");
                p1.MostrarInventario();
                Console.WriteLine($"Inventario de {p2.Nombre}:");
                p2.MostrarInventario();
            }

            Console.ReadLine();
        }

        static Sala GenerarSalaAleatoria(Random rand, string[] poolItems)
        {
            int dificultad = rand.Next(5, 40);
            string item = poolItems[rand.Next(poolItems.Length)];
            int poderItem = rand.Next(2, 15);
            return new Sala(dificultad, item, poderItem);
        }

        static void AnunciarGanador(Personaje ganador)
        {
            Console.WriteLine($"El ganador es: {ganador.Nombre}");
            Console.WriteLine($"Poder total: {ganador.Poder}");
            ganador.MostrarInventario();
        }
    }
}


