namespace ConsoleApp1
{
    public struct Personaje
    {
        public string Nombre { get; set; }
        public int Poder { get; set; }
        public string[] Items { get; set; } 

        public Personaje(string nombre, int poder)
        {
            Nombre = nombre;
            Poder = poder;
            Items = new string[20];
        }
        public void robar(Salas sala)
        {
            if (Poder > sala.Dificultad)
            {
                bool inventarioLleno = true;
                for (int j = 0; j < Items.Length; j++)
                {
                    if (Items[j] == null)
                    {
                        Items[j] = sala.Item;
                        Poder += sala.Poderitem;
                        Console.WriteLine($"{Nombre} robo {sala.Item}, +{sala.Poderitem} Poder. Poder actual: {Poder}");
                        inventarioLleno = false;
                        break; 
                    }
                }

                if (inventarioLleno)
                {
                    Console.WriteLine($"{Nombre} supero la sala, pero su inventario esta lleno.");
                }
            }
            else
            {
                Console.WriteLine($"{Nombre} no agarro nada. Dificultad de la sala: {sala.Dificultad}  Su Poder: {Poder}");
            }
        }

        public void inventario()
        {
            Console.Write(" Items: ");
            bool tieneItems = false;

            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i] != null)
                {
                    Console.Write(Items[i] + " ");
                    tieneItems = true;
                }
            }

            if (!tieneItems)
            {
                Console.Write("Ninguno");
            }
            Console.WriteLine();
        }
    }

    public struct Salas
    {
        public int Dificultad { get; set; }
        public string Item { get; set; }
        public int Poderitem { get; set; }

        public Salas(int dificultad, string item, int poderitem)
        {
            Dificultad = dificultad;
            Item = item;
            Poderitem = poderitem;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            Personaje Fede = new Personaje("Fede", 50);
            Personaje Cody = new Personaje("Cody", 60);

            string[] items = { "Espada de Hierro", "Armadura", "Amuleto Magico", "Pocion" };

            for (int turno = 1; turno <= 20; turno++)
            {
                Console.WriteLine($"Turno {turno}");

                Salas salacody = SalaAle(aleatorio, items);
                Fede.robar(salacody);

   
                Salas salafede = SalaAle(aleatorio, items);
                Cody.robar(salafede);

                Console.WriteLine();
            }

            Console.WriteLine($"{Fede.Nombre} Poder Final: {Fede.Poder}");
            Console.WriteLine($"{Cody.Nombre} Poder Final: {Cody.Poder}");
 

            if (Fede.Poder > Cody.Poder)
            {
                ganadord(Fede);
            }
            else if (Cody.Poder > Fede.Poder)
            {
                ganadord(Cody);
            }
            else
            {
                Console.WriteLine("Hay un empate");
                Console.WriteLine($"Inventario de {Fede.Nombre}:");
                Fede.inventario();
                Console.WriteLine($"Inventario de {Cody.Nombre}:");
                Cody.inventario();
            }

            Console.ReadLine();
        }

        static Salas SalaAle(Random aleatorio, string[] items)
        {
            int dificultad = aleatorio.Next(40, 80); 
            string item = items[aleatorio.Next(items.Length)];
            int poderItem = aleatorio.Next(10, 30);
            return new Salas(dificultad, item, poderItem);
        }

        static void ganadord(Personaje ganador)
        {
            Console.WriteLine($"El ganador es: {ganador.Nombre}");
            Console.WriteLine($"Poder total: {ganador.Poder}");
            ganador.inventario();
        }
    }
}
