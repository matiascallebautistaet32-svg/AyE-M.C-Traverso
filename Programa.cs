using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3
{

    public class AppDbContext : DbContext
    {
        public DbSet<Pokemon> pokemon => Set<Pokemon>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = "Server=localhost;Port=3307;Database=pokedex;Uid=root;pwd=";
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }

    public class Pokemon
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string tipo_1 { get; set; } = string.Empty;
        public string? tipo_2 { get; set; }
        public int hp { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int ataque_especial { get; set; }
        public int defensa_especial { get; set; }
        public int velocidad { get; set; }
        public int nivel { get; set; }
    }

    public class Nodo
    {
        public Pokemon pokemon { get; set; }
        public Nodo nodoI { get; set; }
        public Nodo nodoD { get; set; }

        public Nodo(Pokemon nuevoPokemon)
        {
            pokemon = nuevoPokemon;
            nodoI = null;
            nodoD = null;
        }
    }


    public class Tree
    {
        public Nodo ra { get; set; }

        public Tree()
        {
            ra = null;
        }

        public void Inserto(Pokemon nuevoPokemon)
        {
            ra = Insertando(nuevoPokemon, ra);
        }

        public Nodo Insertando(Pokemon nuevoPokemon, Nodo nodoAct)
        {
            if (nodoAct == null)
            {
                return new Nodo(nuevoPokemon);
            }

            if (nuevoPokemon.id < nodoAct.pokemon.id)
            {
                nodoAct.nodoI = Insertando(nuevoPokemon, nodoAct.nodoI);
            }
            else if (nuevoPokemon.id > nodoAct.pokemon.id)
            {
                nodoAct.nodoD = Insertando(nuevoPokemon, nodoAct.nodoD);
            }

            return nodoAct;
        }

        public string Buscar(int idBusc)
        {
            if (ra == null)
            {
                return "Arbol vacio";
            }

            return Buscando(ra, idBusc);
        }

        public string Buscando(Nodo nodoA, int idBusc)
        {
            if (nodoA == null)
            {
                return "No hay pokemon con el ID " + idBusc + ".";
            }

            if (idBusc == nodoA.pokemon.id)
            {
                return "Pokemon encontrado: Nombre:" + nodoA.pokemon.nombre + " Tipo 1:" + nodoA.pokemon.tipo_1 + " Tipo 2:" + (nodoA.pokemon.tipo_2 ?? "NULL") + " Nivel:" + nodoA.pokemon.nivel;
            }

            if (idBusc < nodoA.pokemon.id)
            {
                return Buscando(nodoA.nodoI, idBusc);
            }
            else
            {
                return Buscando(nodoA.nodoD, idBusc);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string resultado = ProgramaPokemon();
            Console.WriteLine(resultado);

            Console.ReadKey();
        }

        static string ProgramaPokemon()
        {
            string rutaArchivo = "pokedex.json";
            Tree arbol = new Tree();

    
            using (AppDbContext context = new AppDbContext())
            {
         
                List<Pokemon> baseDatosPokemon = context.pokemon.ToList();

        
                var opciones = new JsonSerializerOptions { WriteIndented = true };
                string jsonTexto = JsonSerializer.Serialize(baseDatosPokemon, opciones);
                File.WriteAllText(rutaArchivo, jsonTexto);
            }

            if (File.Exists(rutaArchivo))
            {
                string contenidoJson = File.ReadAllText(rutaArchivo);
                var opcionesLectura = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };


                List<Pokemon>? poke = JsonSerializer.Deserialize<List<Pokemon>>(contenidoJson, opcionesLectura);

                if (poke != null)
                {
      
                    foreach (Pokemon p in poke)
                    {
                        arbol.Inserto(p);
                    }
                }
            }


            string pruebaBusqueda = arbol.Buscar(6); 

            return "JSON exportado desde BD. Lista 'poke' creada desde archivo. Prueba ABB -> " + pruebaBusqueda;
        }
    }
}
