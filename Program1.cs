using System;
using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

namespace Programa8
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var pokedex = new AppDbContext();
            int decision = 0;
            while (decision != 6)
            {
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1- Agregar");
                Console.WriteLine("2- Eliminar");
                Console.WriteLine("3- Actualizar");
                Console.WriteLine("4- Consultar");
                Console.WriteLine("5- Buscar en el arbol");
                Console.WriteLine("6- Finalizar programa");
                decision = int.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre.");
                        string nombreING = Console.ReadLine();

                        Console.WriteLine("Ingrese el tipo 1.");
                        string tipo1ING = Console.ReadLine();

                        Console.WriteLine("Ingrese el tipo 2.");
                        string tipo2ING = Console.ReadLine();

                        Console.WriteLine("Ingrese la vida.");
                        int vidaING = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el ataque");
                        int ataqueING = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la defensa");
                        int defensaING = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el ataque especial");
                        int ataque_especialING = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la defensa especial");
                        int defensa_especialING = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la velocidad");
                        int velocidadING = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el nivel");
                        int nivelING = int.Parse(Console.ReadLine());

                        var nuevoING = new Pokemon
                        {
                            nombre = nombreING,
                            tipo1 = tipo1ING,
                            tipo2 = tipo2ING,
                            vida = vidaING,
                            ataque = ataqueING,
                            defensa = defensaING,
                            ataque_especial = ataque_especialING,
                            defensa_especial = defensa_especialING,
                            velocidad = velocidadING,
                            nivel = nivelING
                        };
                        pokedex.pokemon.Add(nuevoING);
                        await pokedex.SaveChangesAsync();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el id del dato que desea eliminar");
                        int id = int.Parse(Console.ReadLine());
                        var datoBuscado = await pokedex.pokemon.FindAsync(id);
                        if (datoBuscado != null)
                        {
                            pokedex.pokemon.Remove(datoBuscado);
                            await pokedex.SaveChangesAsync();
                        }
                        break;
                    case 3:
                        int modificar = 0;
                        string modificars = "";
                        Console.WriteLine("Ingrese el id del dato que desea modificar");
                        int id2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Que desea modificar?");
                        Console.WriteLine("1- Nombre");
                        Console.WriteLine("2- Tipo 1");
                        Console.WriteLine("3- Tipo 2");
                        Console.WriteLine("4- Vida");
                        Console.WriteLine("5- Ataque");
                        Console.WriteLine("6- Defensa");
                        Console.WriteLine("7- Ataque especial");
                        Console.WriteLine("8- Defensa especial");
                        Console.WriteLine("9- Velocidad");
                        Console.WriteLine("10- Nivel");
                        int decision2 = int.Parse(Console.ReadLine());

                        if (decision2 == 1 || decision2 == 2 || decision2 == 3)
                        {
                            modificars = Console.ReadLine();
                        }
                        else
                        {
                            modificar = int.Parse(Console.ReadLine());
                        }
                        var datoBuscado2 = await pokedex.pokemon.FindAsync(id2);
                        if (datoBuscado2 != null)
                        {
                            switch (decision2)
                            {
                                case 1:
                                    datoBuscado2.nombre = modificars;
                                    break;
                                case 2:
                                    datoBuscado2.tipo1 = modificars;
                                    break;
                                case 3:
                                    datoBuscado2.tipo2 = modificars;
                                    break;
                                case 4:
                                    datoBuscado2.vida = modificar;
                                    break;
                                case 5:
                                    datoBuscado2.ataque = modificar;
                                    break;
                                case 6:
                                    datoBuscado2.defensa = modificar;
                                    break;
                                case 7:
                                    datoBuscado2.ataque_especial = modificar;
                                    break;
                                case 8:
                                    datoBuscado2.defensa_especial = modificar;
                                    break;
                                case 9:
                                    datoBuscado2.velocidad = modificar;
                                    break;
                                case 10:
                                    datoBuscado2.nivel = modificar;
                                    break;
                            }

                            await pokedex.SaveChangesAsync();
                        }
                        break;
                    case 4:
                        var todos = await pokedex.pokemon.ToListAsync();
                        foreach (var e in todos)
                        {
                            Console.WriteLine(" ID: " + e.Id);
                            Console.Write(" NOMBRE: " + e.nombre);
                            Console.Write(" TIPO1: " + e.tipo1);
                            Console.Write(" TIPO2: " + e.tipo2);
                            Console.Write(" VIDA: " + e.vida);
                            Console.Write(" ATAQUE: " + e.ataque);
                            Console.Write(" DEFENSA: " + e.defensa);
                            Console.Write(" ATAQUE ESPECIAL: " + e.ataque_especial);
                            Console.Write(" DEFENSA ESPECIAL: " + e.defensa_especial);
                            Console.Write(" VELOCIDAD " + e.velocidad);
                            Console.Write(" NIVEL: " + e.nivel);
                            Pokemon pokemon = new Pokemon();
                            pokemon = e;
                        }
                        break;
                    case 5:
                        var todos2 = await pokedex.pokemon.ToListAsync();
                        Arbol Arbolito = new Arbol();

                        foreach (var e in todos2)
                        {

                            Pokemones nuevoPokemon = new Pokemones();
                            nuevoPokemon.id = e.Id;
                            nuevoPokemon.nombre = e.nombre;
                            nuevoPokemon.tipo1 = e.tipo1;
                            nuevoPokemon.tipo2 = e.tipo2;
                            nuevoPokemon.vida = e.vida;
                            nuevoPokemon.ataque = e.ataque;
                            nuevoPokemon.defensa = e.defensa;
                            nuevoPokemon.ataque_especial = e.ataque_especial;
                            nuevoPokemon.defensa_especial = e.defensa_especial;
                            nuevoPokemon.velocidad = e.velocidad;
                            nuevoPokemon.nivel = e.nivel;


                            Arbolito.Insertar(nuevoPokemon);
                        }

                        Console.WriteLine("Ingresa el id del pokemon que desea buscar");
                        int Buscar = int.Parse(Console.ReadLine());
                        var encontrado = Arbolito.Buscar(Buscar);
                        if (encontrado != null)
                        {
                            Console.WriteLine($"Encontrado: {encontrado}");
                        }
                        else
                        {
                            Console.WriteLine("Pokémon con ID 5 no encontrado en el árbol.");
                        }



                        break;
                    default:
                        Console.WriteLine("Ingrese un numero valido");
                        break;
                }

            }
        }
    }
}